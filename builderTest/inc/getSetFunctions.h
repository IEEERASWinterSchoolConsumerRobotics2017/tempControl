#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <arpa/inet.h>
//#include "app_main.h"
//#include "uib_app_manager.h"

#define SRV_IP "999.999.999.999"
#define BUFSIZE 256

void set_temp(int temp);