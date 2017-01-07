S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20161216.2057
Build-Date: 2016.12.16 20:57:46

Crash Information
Process Name: buildertest
PID: 3425
Date: 2017-01-07 15:17:10+0900
Executable File Path: /opt/usr/apps/org.example.buildertest/bin/buildertest
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x34890874

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000100, esi = 0x34890874
ebp = 0xbfbebf08, esp = 0xbfbebd3c
eax = 0x00000000, ebx = 0xb7578ff4
ecx = 0x00000001, edx = 0xb41421b6
eip = 0xb746e6ac

Memory Information
MemTotal:      123 KB
MemFree:        62 KB
Buffers:         3 KB
Cached:     126928 KB
VmPeak:      94400 KB
VmSize:      94400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15152 KB
VmRSS:       15152 KB
VmData:      29748 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32248 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3425 TID = 3425
3425 3432 3433 3434 

Maps Information
b1e57000 b1e58000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2201000 b2209000 r-xp /usr/lib/libfeedback.so.0.1.4
b2224000 b2225000 r-xp /usr/lib/edje/modules/feedback/linux-gnu-i686-1.0.0/module.so
b2226000 b224a000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b224f000 b2252000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b2253000 b225c000 r-xp /usr/lib/libtbm.so.1.0.0
b225d000 b2268000 r-xp /usr/lib/libdrm.so.2.4.0
b2275000 b2277000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b2278000 b2286000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b2287000 b2296000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3aaf000 b3ab7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3ab8000 b3bfc000 r-xp /usr/lib/libcairo.so.2.11200.14
b3c00000 b3c23000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3c24000 b3c25000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3c26000 b3c29000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3c2e000 b3c31000 r-xp /usr/lib/libdri2.so.0.0.0
b3c33000 b3c3e000 r-xp /lib/libnss_files-2.13.so
b3f5f000 b3f86000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3f87000 b3fac000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3fad000 b40ce000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b40de000 b4114000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4116000 b4119000 r-xp /usr/lib/libiniparser.so.0
b411b000 b4126000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4127000 b4130000 r-xp /usr/lib/libappsvc.so.0.1.0
b4131000 b4134000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4136000 b413c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b413d000 b4143000 r-xp /opt/usr/apps/org.example.buildertest/bin/buildertest
b4144000 b414a000 r-xp /usr/lib/libogg.so.0.7.1
b414b000 b4176000 r-xp /usr/lib/libvorbis.so.0.4.3
b4177000 b4262000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4270000 b4272000 r-xp /usr/lib/libXau.so.6.0.0
b4273000 b42cc000 r-xp /usr/lib/libssl.so.1.0.0
b42d1000 b4302000 r-xp /usr/lib/libidn.so.11.5.44
b4303000 b4313000 r-xp /usr/lib/libcares.so.2.1.0
b4314000 b437d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4383000 b438f000 r-xp /usr/lib/libsensord-shared.so
b4390000 b43b6000 r-xp /lib/libexpat.so.1.5.2
b43b8000 b43df000 r-xp /usr/lib/libpng12.so.0.50.0
b43e0000 b4400000 r-xp /usr/lib/libxcb.so.1.1.0
b4401000 b4470000 r-xp /usr/lib/libcurl.so.4.3.0
b4472000 b447d000 r-xp /usr/lib/libethumb.so.1.7.99
b5cfa000 b5dd2000 r-xp /usr/lib/libstdc++.so.6.0.16
b5dde000 b5de1000 r-xp /usr/lib/libctxdata.so.0.0.0
b5de2000 b5df8000 r-xp /usr/lib/libremix.so.0.0.0
b5df9000 b5dfb000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5dfc000 b5e28000 r-xp /usr/lib/liblua-5.1.so
b5e29000 b5e33000 r-xp /usr/lib/libembryo.so.1.7.99
b5e34000 b5e7a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e8b000 b5eba000 r-xp /usr/lib/libsensor.so.1.9.0
b5ebb000 b5f3d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f42000 b5f76000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5f78000 b5fd3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5fd5000 b5feb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fec000 b6078000 r-xp /usr/lib/libfreetype.so.6.11.3
b607c000 b607f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6080000 b6086000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6087000 b608d000 r-xp /usr/lib/libecore_fb.so.1.7.99
b608f000 b60a0000 r-xp /usr/lib/libXext.so.6.4.0
b60a1000 b61d5000 r-xp /usr/lib/libX11.so.6.3.0
b61d9000 b61de000 r-xp /usr/lib/libXtst.so.6.1.0
b61df000 b61e7000 r-xp /usr/lib/libXrender.so.1.3.0
b61e8000 b61f1000 r-xp /usr/lib/libXrandr.so.2.2.0
b61f2000 b61f4000 r-xp /usr/lib/libXinerama.so.1.0.0
b61f5000 b6203000 r-xp /usr/lib/libXi.so.6.1.0
b6204000 b6208000 r-xp /usr/lib/libXfixes.so.3.1.0
b6209000 b620b000 r-xp /usr/lib/libXgesture.so.7.0.0
b620c000 b620e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b620f000 b6211000 r-xp /usr/lib/libXdamage.so.1.1.0
b6212000 b621b000 r-xp /usr/lib/libXcursor.so.1.0.2
b621c000 b6247000 r-xp /usr/lib/libecore_con.so.1.7.99
b6249000 b6251000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6252000 b625d000 r-xp /usr/lib/libethumb_client.so.1.7.99
b625e000 b6264000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6265000 b6286000 r-xp /usr/lib/libefreet.so.1.7.99
b6288000 b6294000 r-xp /usr/lib/libedbus.so.1.7.99
b6295000 b6424000 r-xp /usr/lib/libicuuc.so.57.1
b6433000 b66af000 r-xp /usr/lib/libicui18n.so.57.1
b66b8000 b6756000 r-xp /usr/lib/libedje.so.1.7.99
b6758000 b6769000 r-xp /usr/lib/libecore_input.so.1.7.99
b676a000 b6771000 r-xp /usr/lib/libecore_file.so.1.7.99
b6772000 b6798000 r-xp /usr/lib/libeet.so.1.7.99
b67a1000 b68cb000 r-xp /usr/lib/libevas.so.1.7.99
b68e9000 b691d000 r-xp /usr/lib/libecore_evas.so.1.7.99
b691f000 b6963000 r-xp /usr/lib/libecore_x.so.1.7.99
b6965000 b6b60000 r-xp /usr/lib/libelementary.so.1.7.99
b6b6f000 b6b71000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6b72000 b6b78000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6b79000 b6b7d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6b82000 b6b83000 r-xp /usr/lib/libjournal.so.0.1.0
b6b84000 b6ccc000 r-xp /usr/lib/libxml2.so.2.7.8
b6cd2000 b6ce5000 r-xp /lib/libresolv-2.13.so
b6ce9000 b6d06000 r-xp /lib/libz.so.1.2.5
b6d07000 b6d0a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d0c000 b6d11000 r-xp /usr/lib/libffi.so.5.0.10
b6d12000 b6d13000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d14000 b6d18000 r-xp /lib/libattr.so.1.1.0
b6d19000 b6f2c000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f47000 b6f68000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f6a000 b6f92000 r-xp /lib/libm-2.13.so
b6f94000 b6fef000 r-xp /usr/lib/libeina.so.1.7.99
b6ff1000 b6ffc000 r-xp /usr/lib/libvconf.so.0.2.45
b6ffd000 b7000000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7001000 b704f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7051000 b71b2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71b6000 b71bd000 r-xp /lib/librt-2.13.so
b71bf000 b71c6000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b71c8000 b71e2000 r-xp /lib/libgcc_s-4.6.4.so.1
b71e3000 b71eb000 r-xp /lib/libcrypt-2.13.so
b7215000 b7219000 r-xp /lib/libcap.so.2.21
b721a000 b721c000 r-xp /usr/lib/libiri.so
b721d000 b7249000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b724a000 b726a000 r-xp /usr/lib/libecore.so.1.7.99
b7279000 b7282000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7283000 b73a6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73a8000 b73bb000 r-xp /usr/lib/libail.so.0.1.0
b73bc000 b73e1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b73e2000 b73ec000 r-xp /lib/libunwind.so.8.0.1
b73f6000 b7576000 r-xp /lib/libc-2.13.so
b757d000 b75c7000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75c9000 b75ce000 r-xp /usr/lib/libbundle.so.0.1.22
b75cf000 b75d2000 r-xp /lib/libdl-2.13.so
b75d4000 b75eb000 r-xp /lib/libpthread-2.13.so
b75ef000 b75f2000 r-xp /usr/lib/libdlog.so.0.0.0
b75f3000 b75f5000 r-xp /usr/lib/libttrace.so.1.1
b75f6000 b75fb000 r-xp /usr/lib/libsmack.so.1.0.0
b75fc000 b76a4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76a7000 b76c1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c2000 b76d2000 r-xp /usr/lib/libaul.so.0.1.0
b76d5000 b76db000 r-xp /usr/lib/libappcore-common.so.1.1
b76dc000 b76e1000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e3000 b76e8000 r-xp /usr/lib/libsys-assert.so
b76eb000 b76ec000 r-xp [vdso]
b76ec000 b770a000 r-xp /lib/ld-2.13.so
b770c000 b7713000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:3425)
Call Stack Count: 32
 0: cfree + 0x5c (0xb746e6ac) [/lib/libc.so.6] + 0x786ac
 1: view1_button1_onclicked + 0x69 (0xb413f6e9) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x26e9
 2: evas_object_smart_callback_call + 0xe2 (0xb67e8532) [/usr/lib/libevas.so.1] + 0x47532
 3: (0xb69cf6d6) [/usr/lib/libelementary.so.1] + 0x6a6d6
 4: (0xb6722d10) [/usr/lib/libedje.so.1] + 0x6ad10
 5: (0xb672a142) [/usr/lib/libedje.so.1] + 0x72142
 6: (0xb6723dec) [/usr/lib/libedje.so.1] + 0x6bdec
 7: edje_object_message_signal_process + 0x1ab (0xb672415b) [/usr/lib/libedje.so.1] + 0x6c15b
 8: (0xb6a5f54e) [/usr/lib/libelementary.so.1] + 0xfa54e
 9: (0xb6a6181a) [/usr/lib/libelementary.so.1] + 0xfc81a
10: elm_layout_text_set + 0x90 (0xb6a609f0) [/usr/lib/libelementary.so.1] + 0xfb9f0
11: elm_widget_text_part_set + 0x78 (0xb6acd758) [/usr/lib/libelementary.so.1] + 0x168758
12: elm_object_part_text_set + 0x2f (0xb6a6e63f) [/usr/lib/libelementary.so.1] + 0x10963f
13: view1_button1_onunpressed + 0x51 (0xb413f751) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x2751
14: evas_object_smart_callback_call + 0xe2 (0xb67e8532) [/usr/lib/libevas.so.1] + 0x47532
15: (0xb69cf978) [/usr/lib/libelementary.so.1] + 0x6a978
16: (0xb6722d10) [/usr/lib/libedje.so.1] + 0x6ad10
17: (0xb672a142) [/usr/lib/libedje.so.1] + 0x72142
18: (0xb6723dec) [/usr/lib/libedje.so.1] + 0x6bdec
19: (0xb672431f) [/usr/lib/libedje.so.1] + 0x6c31f
20: (0xb67244d4) [/usr/lib/libedje.so.1] + 0x6c4d4
21: (0xb7256f32) [/usr/lib/libecore.so.1] + 0xcf32
22: (0xb7253519) [/usr/lib/libecore.so.1] + 0x9519
23: (0xb725847a) [/usr/lib/libecore.so.1] + 0xe47a
24: ecore_main_loop_begin + 0x3f (0xb72589cf) [/usr/lib/libecore.so.1] + 0xe9cf
25: elm_run + 0x17 (0xb6a6e0f7) [/usr/lib/libelementary.so.1] + 0x1090f7
26: appcore_efl_main + 0x418 (0xb76defe8) [/usr/lib/libappcore-efl.so.1] + 0x2fe8
27: ui_app_main + 0x130 (0xb6b7b4c0) [/usr/lib/libcapi-appfw-application.so.0] + 0x24c0
28: app_run + 0x1d1 (0xb413eed1) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x1ed1
29: main + 0x63 (0xb413f153) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x2153
30: uib_view1_config_CIRCLE_360x360_portrait + 0x79 (0xb770f659) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0xb770f659
31: __libc_start_main + 0xf3 (0xb740f1a3) [/lib/libc.so.6] + 0x191a3
End of Call Stack

Package Information
Package Name: org.example.buildertest
Package ID : org.example.buildertest
Version: 1.0.0
Package Type: rpm
App Name: buildertest
App ID: org.example.buildertest
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
essfully.
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/datasharing
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/internet
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.852+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/message.read
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/message.write
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/network.get
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/network.profile
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/network.set
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/nfc
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/nfc.cardemulation
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/notification
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(281) > Checking privilege = http://tizen.org/privilege/push
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(37) > Matched privilege name exist
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Check api version
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(345) > visibility = 64
01-07 15:16:57.862+0900 D/PRIVILEGE_MANAGER( 3365): privilege_manager.c: privilege_manager_verify_privilege(346) > privilege level = 0
01-07 15:16:57.862+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_verify_privilege_list(752) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
01-07 15:16:57.862+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_package_install(2363) > _coretpk_installer_verify_privilege_list done.
01-07 15:16:57.862+0900 D/rpm-installer( 3365): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.buildertest], key=[install_percent], val=[100]
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.882+0900 D/ADD_VIEWER( 2427): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.buildertest] 100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.882+0900 D/W_HOME  ( 2427): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.buildertest key:install_percent val:100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.882+0900 D/APPS    ( 2427): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.buildertest
01-07 15:16:57.882+0900 D/APPS    ( 2427): pkgmgr.c: _install_percent(469) >  package(org.example.buildertest) with 100
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.882+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.912+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.912+0900 D/PKGMGR  ( 2434): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.912+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.912+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.912+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_package_install(2385) > install status is [2].
01-07 15:16:57.912+0900 D/rpm-installer( 3365): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
01-07 15:16:57.912+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_package_install(2397) > _coretpk_installer_package_install is done.
01-07 15:16:57.912+0900 D/rpm-installer( 3365): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.buildertest], key=[end], val=[ok]
01-07 15:16:57.912+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2964) > success
01-07 15:16:57.922+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.922+0900 D/PKGMGR  ( 2508): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.922+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.922+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.922+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.922+0900 D/PKGMGR  ( 2426): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.922+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.922+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.922+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / install_percent / 100
01-07 15:16:57.922+0900 D/PKGMGR  ( 2438): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 15:16:57.922+0900 D/DATA_PROVIDER_MASTER( 2438): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.buildertest] 100
01-07 15:16:57.922+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.922+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:57.992+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:57.992+0900 D/PKGMGR  ( 2508): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:57.992+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:57.992+0900 D/PKGMGR  ( 2508): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.012+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.012+0900 D/PKGMGR  ( 2438): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.012+0900 D/DATA_PROVIDER_MASTER( 2438): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.buildertest] ok
01-07 15:16:58.042+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.042+0900 D/PKGMGR  ( 2426): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.042+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.042+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.042+0900 D/rpm-installer( 3365): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
01-07 15:16:58.062+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.062+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.062+0900 D/ADD_VIEWER( 2427): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.buildertest] ok
01-07 15:16:58.082+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.082+0900 D/PKGMGR  ( 2438): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.082+0900 D/rpm-installer( 3365): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.buildertest, 7), result=[0]
01-07 15:16:58.102+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.102+0900 D/PKGMGR  ( 2434): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.102+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.102+0900 D/PKGMGR  ( 2434): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.112+0900 D/PKGMGR  ( 2331): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.112+0900 D/PKGMGR  ( 2331): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.112+0900 D/AUL_AMD ( 2331): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.buildertest), key(end), value(ok)
01-07 15:16:58.112+0900 D/AUL_AMD ( 2331): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.192+0900 D/W_HOME  ( 2427): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.buildertest key:end val:ok
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403 / coretpk / org.example.buildertest / end / ok
01-07 15:16:58.192+0900 D/PKGMGR  ( 2427): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.buildertest-1.0.0-i386.tpk_342609403] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 15:16:58.192+0900 D/APPS    ( 2427): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.buildertest
01-07 15:16:58.192+0900 D/APPS    ( 2427): pkgmgr.c: _end(651) >  Package(org.example.buildertest) : key(update) - val(ok)
01-07 15:16:58.282+0900 D/AUL_AMD ( 2331): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
01-07 15:16:58.302+0900 D/AUL_AMD ( 2331): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.buildertest, comp:ui, type:rpm
01-07 15:16:58.302+0900 D/PKGMGR  ( 2331): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:58.302+0900 D/PKGMGR  ( 2331): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:16:58.412+0900 D/APPS    ( 2427): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.buildertest]
01-07 15:16:58.422+0900 D/APPS    ( 2427): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.buildertest]'s item object
01-07 15:16:58.432+0900 D/APPS    ( 2427): db.c: apps_db_remove_item(404) >  Remove the item[org.example.buildertest]
01-07 15:16:58.462+0900 D/rpm-installer( 3365): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
01-07 15:16:58.462+0900 D/rpm-installer( 3365): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2974) > _ri_privilege_enable_permissions(privilege/appdebugging succeeded for debug_mode.
01-07 15:16:58.462+0900 D/rpm-installer( 3365): rpm-appcore-intf.c: main(225) > sync() start
01-07 15:16:58.502+0900 D/APPS    ( 2427): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.buildertest], name[buildertest]
01-07 15:16:58.502+0900 D/APPS    ( 2427): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.buildertest]
01-07 15:16:58.522+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
01-07 15:16:58.522+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 101 bytes
01-07 15:16:58.532+0900 D/DATA_PROVIDER_MASTER( 2438): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-07 15:16:58.572+0900 D/rpm-installer( 3365): rpm-appcore-intf.c: main(227) > sync() end
01-07 15:16:58.632+0900 D/BADGE   ( 2438): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 15:16:58.632+0900 D/rpm-installer( 3365): rpm-appcore-intf.c: main(246) > ------------------------------------------------
01-07 15:16:58.632+0900 D/rpm-installer( 3365): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
01-07 15:16:58.632+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-07 15:16:58.632+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2438, fd: -1
01-07 15:16:58.632+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2438), fd: -1
01-07 15:16:58.632+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-07 15:16:58.632+0900 D/APPS    ( 2427): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.buildertest]
01-07 15:16:58.632+0900 E/DATA_PROVIDER_MASTER( 2438): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-07 15:16:58.632+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
01-07 15:16:58.642+0900 D/COM_CORE( 2438): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-07 15:16:58.642+0900 D/rpm-installer( 3365): rpm-appcore-intf.c: main(248) > ------------------------------------------------
01-07 15:16:58.642+0900 D/DATA_PROVIDER_MASTER( 2438): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8bb1380 is terminated (NIL packet)
01-07 15:16:58.642+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-07 15:16:58.642+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 101 bytes
01-07 15:16:58.652+0900 D/DATA_PROVIDER_MASTER( 2438): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-07 15:16:58.682+0900 D/PKGMGR_SERVER( 3364): pkgmgr-server.c: sighandler(326) > child exit [3365]
01-07 15:16:58.682+0900 D/PKGMGR_SERVER( 3364): pkgmgr-server.c: sighandler(341) > child NORMAL exit [3365]
01-07 15:16:58.742+0900 D/BADGE   ( 2438): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 15:16:58.742+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-07 15:16:58.742+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2438, fd: -1
01-07 15:16:58.742+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2438), fd: -1
01-07 15:16:58.742+0900 D/COM_CORE( 2427): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-07 15:16:58.742+0900 D/COM_CORE( 2438): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-07 15:16:58.772+0900 E/DATA_PROVIDER_MASTER( 2438): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-07 15:16:58.772+0900 D/DATA_PROVIDER_MASTER( 2438): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8bae528 is terminated (NIL packet)
01-07 15:16:58.772+0900 D/DATA_PROVIDER_MASTER( 2438): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-07 15:16:58.812+0900 D/APPS    ( 2427): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.buildertest], name[buildertest]
01-07 15:16:58.912+0900 D/APPS    ( 2427): item.c: item_create(819) >  Icon size after ea_effect (124:127)
01-07 15:16:58.952+0900 D/BADGE   ( 2427): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 15:16:58.962+0900 D/APPS    ( 2427): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
01-07 15:16:58.962+0900 D/APPS    ( 2427): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.test]'s ordering : 1
01-07 15:16:58.962+0900 D/APPS    ( 2427): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.tempcontrol2]'s ordering : 2
01-07 15:16:58.962+0900 D/APPS    ( 2427): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.buildertest]'s ordering : 3
01-07 15:16:58.962+0900 D/APPS    ( 2427): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
01-07 15:16:58.972+0900 D/APPS    ( 2427): db.c: apps_db_update_item(374) >  Update the item[org.example.test:1]
01-07 15:16:58.982+0900 D/APPS    ( 2427): db.c: apps_db_update_item(374) >  Update the item[org.example.tempcontrol2:2]
01-07 15:16:58.992+0900 D/PKGMGR_SERVER( 3364): pkgmgr-server.c: exit_server(724) > exit_server Start
01-07 15:16:58.992+0900 D/PKGMGR_SERVER( 3364): pkgmgr-server.c: main(1516) > Quit main loop.
01-07 15:16:58.992+0900 D/PKGMGR_SERVER( 3364): pkgmgr-server.c: main(1524) > package manager server terminated.
01-07 15:16:59.062+0900 D/APPS    ( 2427): db.c: apps_db_insert_item(345) >  Insert the item[org.example.buildertest:3]
01-07 15:16:59.232+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 15:16:59.232+0900 D/PKGMGR  ( 2427): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 15:17:00.972+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
01-07 15:17:00.992+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
01-07 15:17:00.992+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: preference_get_int(1063) > preference_get_int(2429) : key(clock_font_color) error
01-07 15:17:00.992+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
01-07 15:17:00.992+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
01-07 15:17:00.992+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2429): preference.c: preference_get_int(1063) > preference_get_int(2429) : key(showdate) error
01-07 15:17:00.992+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: clock_view_set_info_time(877) > show_date:1
01-07 15:17:01.002+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Sat, 7 Jan][1483769820]
01-07 15:17:01.012+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: clock_view_set_info_time(885) > 
01-07 15:17:01.012+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[pm][1483769820]
01-07 15:17:01.012+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[3:17][1483769820]
01-07 15:17:01.012+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: clock_view_set_info_time(899) > utc_time=3:17, utc_ampm=[2]pm
01-07 15:17:01.012+0900 D/IDLE-CLOCK-DIGITAL( 2429): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>3:17<font_size=24><font=Tizen:style=Bold>pm</font></font_size></color>
01-07 15:17:04.622+0900 D/AUL_AMD ( 2331): amd_request.c: __request_handler(506) > __request_handler: 0
01-07 15:17:04.682+0900 D/AUL_AMD ( 2331): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.buildertest
01-07 15:17:04.772+0900 D/AUL     ( 2331): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 3422, pid = 3424
01-07 15:17:04.792+0900 D/AUL_AMD ( 2331): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
01-07 15:17:04.812+0900 D/AUL_AMD ( 2331): amd_launch.c: _start_app(1803) > process_pool: false
01-07 15:17:04.812+0900 D/AUL_AMD ( 2331): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
01-07 15:17:04.812+0900 D/AUL_AMD ( 2331): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.buildertest
01-07 15:17:04.812+0900 D/AUL_AMD ( 2331): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
01-07 15:17:04.812+0900 D/AUL     ( 2331): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
01-07 15:17:04.812+0900 D/AUL_PAD ( 2338): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.buildertest
01-07 15:17:04.812+0900 D/AUL_PAD ( 2338): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
01-07 15:17:04.822+0900 D/AUL_PAD ( 2338): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 3425 /opt/usr/apps/org.example.buildertest/bin/buildertest
01-07 15:17:04.822+0900 D/AUL_PAD ( 2338): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
01-07 15:17:04.822+0900 D/AUL_PAD ( 3425): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
01-07 15:17:04.832+0900 D/AUL_PAD ( 3425): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
01-07 15:17:04.832+0900 D/AUL_PAD ( 3425): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.buildertest / pkg_type : rpm / app_path : /opt/usr/apps/org.example.buildertest/bin/buildertest 
01-07 15:17:04.922+0900 D/AUL_PAD ( 2338): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
01-07 15:17:04.972+0900 D/AUL_PAD ( 3425): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
01-07 15:17:04.972+0900 D/AUL_PAD ( 3425): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.buildertest/bin/buildertest##
01-07 15:17:04.972+0900 D/AUL_PAD ( 3425): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
01-07 15:17:04.972+0900 D/AUL_PAD ( 3425): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
01-07 15:17:04.972+0900 D/LAUNCH  ( 3425): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.buildertest/bin/buildertest:Platform:launchpad:done]
01-07 15:17:05.002+0900 I/efl-extension( 3425): efl_extension.c: eext_mod_init(39) > Init
01-07 15:17:05.022+0900 D/AUL_PAD ( 2338): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
01-07 15:17:05.042+0900 I/CAPI_APPFW_APPLICATION( 3425): app_main.c: ui_app_main(701) > app_efl_main
01-07 15:17:05.042+0900 D/LAUNCH  ( 3425): appcore-efl.c: appcore_efl_main(1597) > [buildertest:Application:main:done]
01-07 15:17:05.132+0900 D/AUL_PAD ( 2338): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
01-07 15:17:05.132+0900 D/AUL_PAD ( 2338): sigchild.h: __send_app_launch_signal(112) > send launch signal done
01-07 15:17:05.132+0900 D/AUL_PAD ( 2338): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
01-07 15:17:05.142+0900 D/AUL     ( 2331): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
01-07 15:17:05.142+0900 E/AUL     ( 2331): simple_util.c: __trm_app_info_send_socket(264) > access
01-07 15:17:05.192+0900 D/RESOURCED( 2471): proc-noti.c: recv_str(87) > [recv_str,87] str is null
01-07 15:17:05.192+0900 D/RESOURCED( 2471): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2331
01-07 15:17:05.192+0900 D/RESOURCED( 2471): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.buildertest, pid 3425, type 4 
01-07 15:17:05.212+0900 D/RESOURCED( 2471): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.buildertest, 3425
01-07 15:17:05.212+0900 D/RESOURCED( 2471): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.buildertest with pkgname
01-07 15:17:05.212+0900 E/RESOURCED( 2471): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 384
01-07 15:17:05.212+0900 D/RESOURCED( 2471): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
01-07 15:17:05.712+0900 D/APP_CORE( 3425): appcore-efl.c: __before_loop(1030) > elm_config_preferred_engine_set is not called
01-07 15:17:05.922+0900 D/AUL     ( 3425): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3425 is org.example.buildertest
01-07 15:17:05.922+0900 D/APP_CORE( 3425): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.buildertest/res/locale
01-07 15:17:05.932+0900 D/APP_CORE( 3425): appcore-i18n.c: update_region(74) > *****appcore setlocale=en_GB.UTF-8
01-07 15:17:05.952+0900 D/AUL     ( 3425): app_sock.c: __create_server_sock(141) > pg path - already exists
01-07 15:17:05.962+0900 D/LAUNCH  ( 3425): appcore-efl.c: __before_loop(1048) > [buildertest:Platform:appcore_init:done]
01-07 15:17:05.962+0900 I/CAPI_APPFW_APPLICATION( 3425): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
01-07 15:17:06.152+0900 D/AUL_AMD ( 2331): amd_launch.c: __grab_timeout_handler(1222) > pid(3425) ecore_x_pointer_ungrab
01-07 15:17:06.162+0900 D/AUL_AMD ( 2331): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.buildertest /opt/usr/apps/org.example.buildertest/bin/buildertest
01-07 15:17:06.162+0900 D/RUA     ( 2331): rua.c: rua_add_history(179) > rua_add_history start
01-07 15:17:06.352+0900 D/RUA     ( 2331): rua.c: rua_add_history(247) > rua_add_history ok
01-07 15:17:06.902+0900 E/EFL     ( 3425): eina_module<3425> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-07 15:17:06.992+0900 E/EFL     ( 3425): ecore_evas<3425> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
01-07 15:17:07.062+0900 E/EFL     ( 3425): eina_module<3425> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
01-07 15:17:07.102+0900 E/EFL     ( 3425): elementary<3425> elm_widget.c:4357 elm_widget_type_check() Passing Object: 0xb8958bf0 in function: elm_win_alpha_set, of type: 'elm_box' when expecting type: 'elm_win'
01-07 15:17:07.372+0900 D/LAUNCH  ( 3425): appcore-efl.c: __before_loop(1066) > [buildertest:Application:create:done]
01-07 15:17:07.372+0900 D/APP_CORE( 3425): appcore-efl.c: __check_wm_rotation_support(765) > Disable window manager rotation
01-07 15:17:07.372+0900 D/APP_CORE( 3425): appcore-rotation.c: __changed_cb(123) > [APP 3425] Rotation: 0 -> 1
01-07 15:17:07.372+0900 D/APP_CORE( 3425): appcore-rotation.c: __changed_cb(128) > [APP 3425] Rotation: 0 -> 1
01-07 15:17:07.372+0900 I/CAPI_APPFW_APPLICATION( 3425): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
01-07 15:17:07.422+0900 D/APP_CORE( 3425): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
01-07 15:17:07.422+0900 D/APP_CORE( 3425): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
01-07 15:17:07.622+0900 D/APP_CORE( 3425): appcore.c: __aul_handler(423) > [APP 3425]     AUL event: AUL_START
01-07 15:17:07.622+0900 D/APP_CORE( 3425): appcore-efl.c: __do_app(471) > [APP 3425] Event: RESET State: CREATED
01-07 15:17:07.622+0900 D/APP_CORE( 3425): appcore-efl.c: __do_app(497) > [APP 3425] RESET
01-07 15:17:07.622+0900 D/LAUNCH  ( 3425): appcore-efl.c: __do_app(499) > [buildertest:Application:reset:start]
01-07 15:17:07.622+0900 I/CAPI_APPFW_APPLICATION( 3425): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
01-07 15:17:07.632+0900 D/APP_SVC ( 3425): appsvc.c: __set_bundle(161) > __set_bundle
01-07 15:17:07.632+0900 D/LAUNCH  ( 3425): appcore-efl.c: __do_app(506) > [buildertest:Application:reset:done]
01-07 15:17:07.732+0900 I/APP_CORE( 3425): appcore-efl.c: __do_app(512) > Legacy lifecycle: 0
01-07 15:17:07.732+0900 I/APP_CORE( 3425): appcore-efl.c: __do_app(514) > [APP 3425] Initial Launching, call the resume_cb
01-07 15:17:07.732+0900 I/CAPI_APPFW_APPLICATION( 3425): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
01-07 15:17:07.732+0900 D/APP_CORE( 3425): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
01-07 15:17:07.732+0900 D/APP_CORE( 3425): appcore.c: __prt_ltime(183) > [APP 3425] first idle after reset: 3129 msec
01-07 15:17:07.742+0900 D/APP_CORE( 3425): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
01-07 15:17:07.742+0900 D/APP_CORE( 3425): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
01-07 15:17:07.742+0900 D/APP_CORE( 3425): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
01-07 15:17:07.742+0900 D/APP_CORE( 3425): appcore-efl.c: __do_app(471) > [APP 3425] Event: RESUME State: RUNNING
01-07 15:17:07.742+0900 D/LAUNCH  ( 3425): appcore-efl.c: __do_app(566) > [buildertest:Application:resume:start]
01-07 15:17:07.742+0900 D/LAUNCH  ( 3425): appcore-efl.c: __do_app(580) > [buildertest:Application:resume:done]
01-07 15:17:07.742+0900 D/LAUNCH  ( 3425): appcore-efl.c: __do_app(582) > [buildertest:Application:Launching:done]
01-07 15:17:07.742+0900 D/APP_CORE( 3425): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
01-07 15:17:07.742+0900 E/APP_CORE( 3425): appcore-efl.c: __trm_app_info_send_socket(234) > access
01-07 15:17:07.742+0900 W/W_HOME  ( 2427): main.c: _window_visibility_cb(796) > Window [0x1000003] is now visible(1)
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1000003 fully_obscured 1
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __do_app(471) > [APP 2427] Event: PAUSE State: RUNNING
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __do_app(543) > [APP 2427] PAUSE
01-07 15:17:07.762+0900 I/CAPI_APPFW_APPLICATION( 2427): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
01-07 15:17:07.762+0900 D/W_HOME  ( 2427): main.c: _pause_cb(600) > Paused
01-07 15:17:07.762+0900 E/W_HOME  ( 2427): main.c: _pause_cb(603) > paused already
01-07 15:17:07.762+0900 D/APP_CORE( 2427): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
01-07 15:17:07.762+0900 E/APP_CORE( 2427): appcore-efl.c: __trm_app_info_send_socket(234) > access
01-07 15:17:07.802+0900 D/RESOURCED( 2471): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2427, type = 2
01-07 15:17:07.832+0900 D/RESOURCED( 2471): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 3425, type = 0
01-07 15:17:07.832+0900 D/RESOURCED( 2471): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 3425
01-07 15:17:07.832+0900 I/RESOURCED( 2471): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 3425, oom : 200
01-07 15:17:07.832+0900 E/RESOURCED( 2471): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
01-07 15:17:07.862+0900 D/AUL_AMD ( 2331): amd_launch.c: __e17_status_handler(1939) > pid(3425) status(3)
01-07 15:17:08.122+0900 I/GESTURE ( 2192): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
01-07 15:17:08.182+0900 I/GESTURE ( 2192): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
01-07 15:17:08.212+0900 D/EFL     ( 3355): ecore_x<3355> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=572132 button=1
01-07 15:17:08.212+0900 D/EFL     ( 3355): ecore_x<3355> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=572186 button=1
01-07 15:17:08.222+0900 E/EFL     ( 3355): eina_module<3355> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-07 15:17:08.292+0900 D/AUL     ( 3355): app_sock.c: __app_send_raw_with_noreply(370) > pid(-2) : cmd(22)
01-07 15:17:08.292+0900 D/AUL_AMD ( 2331): amd_request.c: __request_handler(506) > __request_handler: 22
01-07 15:17:08.302+0900 D/APP_CORE( 3355): appcore-efl.c: __after_loop(1081) > [APP 3355] PAUSE before termination
01-07 15:17:08.572+0900 I/AUL_PAD ( 2338): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3355 pgid = 3355
01-07 15:17:08.572+0900 I/AUL_PAD ( 2338): sigchild.h: __sigchild_action(123) > dead_pid(3355)
01-07 15:17:08.572+0900 D/AUL_PAD ( 2338): sigchild.h: __send_app_dead_signal(81) > send dead signal done
01-07 15:17:08.572+0900 I/AUL_PAD ( 2338): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
01-07 15:17:08.572+0900 I/AUL_PAD ( 2338): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
01-07 15:17:08.662+0900 I/AUL_AMD ( 2331): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3355
01-07 15:17:08.662+0900 D/AUL_AMD ( 2331): amd_key.c: _unregister_key_event(161) > ===key stack===
01-07 15:17:08.662+0900 D/AUL     ( 2331): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
01-07 15:17:08.662+0900 E/AUL     ( 2331): simple_util.c: __trm_app_info_send_socket(264) > access
01-07 15:17:08.682+0900 D/STARTER ( 2423): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3355)
01-07 15:17:08.712+0900 D/W_HOME  ( 2427): main.c: _dead_cb(542) > PID(3355) is dead
01-07 15:17:08.712+0900 E/W_HOME  ( 2427): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
01-07 15:17:10.302+0900 D/AUL_AMD ( 2331): amd_status.c: __app_terminate_timer_cb(113) > pid(3355)
01-07 15:17:10.302+0900 D/AUL_AMD ( 2331): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
01-07 15:17:10.322+0900 I/GESTURE ( 2192): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
01-07 15:17:10.382+0900 D/EFL     ( 3425): ecore_x<3425> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=574333 button=1
01-07 15:17:10.602+0900 D/EFL     ( 3425): ecore_x<3425> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=574605 button=1
01-07 15:17:10.602+0900 E/EFL     ( 3425): eina_module<3425> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-07 15:17:10.702+0900 I/MyTag   ( 3425): portno successful.
01-07 15:17:10.712+0900 I/MyTag   ( 3425): server successful.
01-07 15:17:10.732+0900 E/MyTag   ( 3425): connection error occurred
01-07 15:17:10.732+0900 I/MyTag   ( 3425): connect successful.
01-07 15:17:10.732+0900 E/MyTag   ( 3425): error occurred at socket
01-07 15:17:10.942+0900 W/CRASH_MANAGER( 3282): worker.c: worker_job(1189) > 1103425627569148376983
