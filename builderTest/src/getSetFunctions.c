#include "getSetFunctions.h"
#include <dlog.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <arpa/inet.h>

void error(char *msg) {
    perror(msg);
    exit(0);
}

char* concat(const char *s1, const char *s2)
{
	char *result = malloc(strlen(s1)+strlen(s2)+1);
	strcpy(result,s1);
	strcpy(result,s2);
	return result;
}

void set_temp(int temp)
{

int sockfd, portno, n;
struct sockaddr_in serv_addr;
struct hostent *server;
char *hostname;
char buf[BUFSIZE];

portno = 8893; //atoi(argv[2]);

dlog_print(DLOG_INFO, "MyTag", "portno successful.");

/* socket: create the socket */
sockfd = socket(AF_INET, SOCK_STREAM, 0);
if (sockfd < 0)
    error("ERROR opening socket");

/* gethostbyname: get the server's DNS entry */
hostname = "localhost";
server = gethostbyname(hostname);
dlog_print(DLOG_INFO, "MyTag", "server successful.");

//server = "010.018.081.007";

/*if (server == NULL) {
    fprintf(stderr,"ERROR, no such host as %s\n", hostname);
    exit(0);
}*/

/* build the server's Internet address */
bzero((char *) &serv_addr, sizeof(serv_addr));
serv_addr.sin_family = AF_INET;

bcopy((char *)server->h_addr,(char *)&serv_addr.sin_addr.s_addr, server->h_length);
serv_addr.sin_port = htons(portno);


/* connect: create a connection with the server */
if (connect(sockfd, &serv_addr, sizeof(serv_addr)) < 0)
   dlog_print(DLOG_ERROR, "MyTag", "connection error occurred");

dlog_print(DLOG_INFO, "MyTag", "connect successful.");
/* get message line from the user */
//printf("Please enter msg: ");
//fgets(buf, BUFSIZE, stdin);

bzero(buf, BUFSIZE);
/*
char s1[23] = "set thermostat des tmp ";
char s2[4];
sprintf(s2,"%d",temp);
char* uf = concat(s1,s2);
*/

char* uf = "set thermostat des 80";
/* send the message line to the server */
n = write(sockfd, buf, strlen(buf));
if (n < 0)
   dlog_print(DLOG_ERROR, "MyTag", "error occurred at socket");


free(uf);

/* print the server's reply */
bzero(buf, BUFSIZE);
n = read(sockfd, buf, BUFSIZE);
if (n < 0)
  error("ERROR reading from socket");
printf("Echo from server: %s", buf);
close(sockfd);
//return 0;

}
