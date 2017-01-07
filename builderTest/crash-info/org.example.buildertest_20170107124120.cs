S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20161216.2057
Build-Date: 2016.12.16 20:57:46

Crash Information
Process Name: buildertest
PID: 3591
Date: 2017-01-07 12:41:20+0900
Executable File Path: /opt/usr/apps/org.example.buildertest/bin/buildertest
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6e6f6320

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfebbf28, esi = 0xb41de1c4
ebp = 0xbfebbf58, esp = 0xbfebbd90
eax = 0x6e6f6320, ebx = 0xb41de1c4
ecx = 0x00000010, edx = 0xbfebbf38
eip = 0xb41da2b6

Memory Information
MemTotal:      123 KB
MemFree:        59 KB
Buffers:         4 KB
Cached:     124380 KB
VmPeak:      94400 KB
VmSize:      94400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15280 KB
VmRSS:       15280 KB
VmData:      29748 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32248 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3591 TID = 3591
3591 3598 3599 3600 

Maps Information
b1ef2000 b1ef3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1ef4000 b1efc000 r-xp /usr/lib/libfeedback.so.0.1.4
b1f17000 b1f18000 r-xp /usr/lib/edje/modules/feedback/linux-gnu-i686-1.0.0/module.so
b2064000 b2088000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b21e9000 b21f2000 r-xp /usr/lib/libtbm.so.1.0.0
b21f3000 b21fe000 r-xp /usr/lib/libdrm.so.2.4.0
b2b01000 b2b04000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b2b11000 b2b13000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b2b14000 b2b22000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b2b23000 b2b32000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3b4a000 b3b52000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3b53000 b3c97000 r-xp /usr/lib/libcairo.so.2.11200.14
b3c9b000 b3cbe000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3cbf000 b3cc0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3cc1000 b3cc4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3cc9000 b3ccc000 r-xp /usr/lib/libdri2.so.0.0.0
b3cce000 b3cd9000 r-xp /lib/libnss_files-2.13.so
b3ffa000 b4021000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4022000 b4047000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4048000 b4169000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4179000 b41af000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b41b1000 b41b4000 r-xp /usr/lib/libiniparser.so.0
b41b6000 b41c1000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b41c2000 b41cb000 r-xp /usr/lib/libappsvc.so.0.1.0
b41cc000 b41cf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41d1000 b41d7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b41d8000 b41de000 r-xp /opt/usr/apps/org.example.buildertest/bin/buildertest
b41df000 b41e5000 r-xp /usr/lib/libogg.so.0.7.1
b41e6000 b4211000 r-xp /usr/lib/libvorbis.so.0.4.3
b4212000 b42fd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b430b000 b430d000 r-xp /usr/lib/libXau.so.6.0.0
b430e000 b4367000 r-xp /usr/lib/libssl.so.1.0.0
b436c000 b439d000 r-xp /usr/lib/libidn.so.11.5.44
b439e000 b43ae000 r-xp /usr/lib/libcares.so.2.1.0
b43af000 b4418000 r-xp /usr/lib/libsndfile.so.1.0.25
b441e000 b442a000 r-xp /usr/lib/libsensord-shared.so
b442b000 b4451000 r-xp /lib/libexpat.so.1.5.2
b4453000 b447a000 r-xp /usr/lib/libpng12.so.0.50.0
b447b000 b449b000 r-xp /usr/lib/libxcb.so.1.1.0
b449c000 b450b000 r-xp /usr/lib/libcurl.so.4.3.0
b450d000 b4518000 r-xp /usr/lib/libethumb.so.1.7.99
b5d95000 b5e6d000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e79000 b5e7c000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e7d000 b5e93000 r-xp /usr/lib/libremix.so.0.0.0
b5e94000 b5e96000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e97000 b5ec3000 r-xp /usr/lib/liblua-5.1.so
b5ec4000 b5ece000 r-xp /usr/lib/libembryo.so.1.7.99
b5ecf000 b5f15000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f26000 b5f55000 r-xp /usr/lib/libsensor.so.1.9.0
b5f56000 b5fd8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fdd000 b6011000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6013000 b606e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6070000 b6086000 r-xp /usr/lib/libfribidi.so.0.3.1
b6087000 b6113000 r-xp /usr/lib/libfreetype.so.6.11.3
b6117000 b611a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b611b000 b6121000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6122000 b6128000 r-xp /usr/lib/libecore_fb.so.1.7.99
b612a000 b613b000 r-xp /usr/lib/libXext.so.6.4.0
b613c000 b6270000 r-xp /usr/lib/libX11.so.6.3.0
b6274000 b6279000 r-xp /usr/lib/libXtst.so.6.1.0
b627a000 b6282000 r-xp /usr/lib/libXrender.so.1.3.0
b6283000 b628c000 r-xp /usr/lib/libXrandr.so.2.2.0
b628d000 b628f000 r-xp /usr/lib/libXinerama.so.1.0.0
b6290000 b629e000 r-xp /usr/lib/libXi.so.6.1.0
b629f000 b62a3000 r-xp /usr/lib/libXfixes.so.3.1.0
b62a4000 b62a6000 r-xp /usr/lib/libXgesture.so.7.0.0
b62a7000 b62a9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62aa000 b62ac000 r-xp /usr/lib/libXdamage.so.1.1.0
b62ad000 b62b6000 r-xp /usr/lib/libXcursor.so.1.0.2
b62b7000 b62e2000 r-xp /usr/lib/libecore_con.so.1.7.99
b62e4000 b62ec000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62ed000 b62f8000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62f9000 b62ff000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6300000 b6321000 r-xp /usr/lib/libefreet.so.1.7.99
b6323000 b632f000 r-xp /usr/lib/libedbus.so.1.7.99
b6330000 b64bf000 r-xp /usr/lib/libicuuc.so.57.1
b64ce000 b674a000 r-xp /usr/lib/libicui18n.so.57.1
b6753000 b67f1000 r-xp /usr/lib/libedje.so.1.7.99
b67f3000 b6804000 r-xp /usr/lib/libecore_input.so.1.7.99
b6805000 b680c000 r-xp /usr/lib/libecore_file.so.1.7.99
b680d000 b6833000 r-xp /usr/lib/libeet.so.1.7.99
b683c000 b6966000 r-xp /usr/lib/libevas.so.1.7.99
b6984000 b69b8000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69ba000 b69fe000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a00000 b6bfb000 r-xp /usr/lib/libelementary.so.1.7.99
b6c0a000 b6c0c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6c0d000 b6c13000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c14000 b6c18000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c1d000 b6c1e000 r-xp /usr/lib/libjournal.so.0.1.0
b6c1f000 b6d67000 r-xp /usr/lib/libxml2.so.2.7.8
b6d6d000 b6d80000 r-xp /lib/libresolv-2.13.so
b6d84000 b6da1000 r-xp /lib/libz.so.1.2.5
b6da2000 b6da5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6da7000 b6dac000 r-xp /usr/lib/libffi.so.5.0.10
b6dad000 b6dae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6daf000 b6db3000 r-xp /lib/libattr.so.1.1.0
b6db4000 b6fc7000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fe2000 b7003000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7005000 b702d000 r-xp /lib/libm-2.13.so
b702f000 b708a000 r-xp /usr/lib/libeina.so.1.7.99
b708c000 b7097000 r-xp /usr/lib/libvconf.so.0.2.45
b7098000 b709b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b709c000 b70ea000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70ec000 b724d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7251000 b7258000 r-xp /lib/librt-2.13.so
b725a000 b7261000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b7263000 b727d000 r-xp /lib/libgcc_s-4.6.4.so.1
b727e000 b7286000 r-xp /lib/libcrypt-2.13.so
b72b0000 b72b4000 r-xp /lib/libcap.so.2.21
b72b5000 b72b7000 r-xp /usr/lib/libiri.so
b72b8000 b72e4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72e5000 b7305000 r-xp /usr/lib/libecore.so.1.7.99
b7314000 b731d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b731e000 b7441000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7443000 b7456000 r-xp /usr/lib/libail.so.0.1.0
b7457000 b747c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b747d000 b7487000 r-xp /lib/libunwind.so.8.0.1
b7491000 b7611000 r-xp /lib/libc-2.13.so
b7618000 b7662000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7664000 b7669000 r-xp /usr/lib/libbundle.so.0.1.22
b766a000 b766d000 r-xp /lib/libdl-2.13.so
b766f000 b7686000 r-xp /lib/libpthread-2.13.so
b768a000 b768d000 r-xp /usr/lib/libdlog.so.0.0.0
b768e000 b7690000 r-xp /usr/lib/libttrace.so.1.1
b7691000 b7696000 r-xp /usr/lib/libsmack.so.1.0.0
b7697000 b773f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7742000 b775c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b775d000 b776d000 r-xp /usr/lib/libaul.so.0.1.0
b7770000 b7776000 r-xp /usr/lib/libappcore-common.so.1.1
b7777000 b777c000 r-xp /usr/lib/libappcore-efl.so.1.1
b777e000 b7783000 r-xp /usr/lib/libsys-assert.so
b7786000 b7787000 r-xp [vdso]
b7787000 b77a5000 r-xp /lib/ld-2.13.so
b77a7000 b77ae000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:3591)
Call Stack Count: 32
 0: set_temp + 0xe6 (0xb41da2b6) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x22b6
 1: view1_button1_onclicked + 0x69 (0xb41da609) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x2609
 2: evas_object_smart_callback_call + 0xe2 (0xb6883532) [/usr/lib/libevas.so.1] + 0x47532
 3: (0xb6a6a6d6) [/usr/lib/libelementary.so.1] + 0x6a6d6
 4: (0xb67bdd10) [/usr/lib/libedje.so.1] + 0x6ad10
 5: (0xb67c5142) [/usr/lib/libedje.so.1] + 0x72142
 6: (0xb67bedec) [/usr/lib/libedje.so.1] + 0x6bdec
 7: edje_object_message_signal_process + 0x1ab (0xb67bf15b) [/usr/lib/libedje.so.1] + 0x6c15b
 8: (0xb6afa54e) [/usr/lib/libelementary.so.1] + 0xfa54e
 9: (0xb6afc81a) [/usr/lib/libelementary.so.1] + 0xfc81a
10: elm_layout_text_set + 0x90 (0xb6afb9f0) [/usr/lib/libelementary.so.1] + 0xfb9f0
11: elm_widget_text_part_set + 0x78 (0xb6b68758) [/usr/lib/libelementary.so.1] + 0x168758
12: elm_object_part_text_set + 0x2f (0xb6b0963f) [/usr/lib/libelementary.so.1] + 0x10963f
13: view1_button1_onunpressed + 0x51 (0xb41da671) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x2671
14: evas_object_smart_callback_call + 0xe2 (0xb6883532) [/usr/lib/libevas.so.1] + 0x47532
15: (0xb6a6a978) [/usr/lib/libelementary.so.1] + 0x6a978
16: (0xb67bdd10) [/usr/lib/libedje.so.1] + 0x6ad10
17: (0xb67c5142) [/usr/lib/libedje.so.1] + 0x72142
18: (0xb67bedec) [/usr/lib/libedje.so.1] + 0x6bdec
19: (0xb67bf31f) [/usr/lib/libedje.so.1] + 0x6c31f
20: (0xb67bf4d4) [/usr/lib/libedje.so.1] + 0x6c4d4
21: (0xb72f1f32) [/usr/lib/libecore.so.1] + 0xcf32
22: (0xb72ee519) [/usr/lib/libecore.so.1] + 0x9519
23: (0xb72f347a) [/usr/lib/libecore.so.1] + 0xe47a
24: ecore_main_loop_begin + 0x3f (0xb72f39cf) [/usr/lib/libecore.so.1] + 0xe9cf
25: elm_run + 0x17 (0xb6b090f7) [/usr/lib/libelementary.so.1] + 0x1090f7
26: appcore_efl_main + 0x418 (0xb7779fe8) [/usr/lib/libappcore-efl.so.1] + 0x2fe8
27: ui_app_main + 0x130 (0xb6c164c0) [/usr/lib/libcapi-appfw-application.so.0] + 0x24c0
28: app_run + 0x1d1 (0xb41d9e51) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x1e51
29: main + 0x63 (0xb41da0d3) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0x20d3
30: uib_view1_config_CIRCLE_360x360_portrait + 0x159 (0xb77aa659) [/opt/usr/apps/org.example.buildertest/bin/buildertest] + 0xb77aa659
31: __libc_start_main + 0xf3 (0xb74aa1a3) [/lib/libc.so.6] + 0x191a3
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
oretpk / org.example.buildertest / install_percent / 60
01-07 12:41:00.637+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[60]
01-07 12:41:00.637+0900 D/APPS    ( 2418): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.buildertest
01-07 12:41:00.637+0900 D/APPS    ( 2418): pkgmgr.c: _install_percent(469) >  package(org.example.buildertest) with 60
01-07 12:41:00.637+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:00.637+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:00.647+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 60
01-07 12:41:00.647+0900 D/PKGMGR  ( 2423): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[60]
01-07 12:41:00.647+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:00.647+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:00.677+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 60
01-07 12:41:00.677+0900 D/PKGMGR  ( 2426): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[60]
01-07 12:41:00.677+0900 D/DATA_PROVIDER_MASTER( 2426): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.buildertest] 60
01-07 12:41:00.677+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:00.677+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:00.687+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
01-07 12:41:00.717+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 60
01-07 12:41:00.717+0900 D/PKGMGR  ( 2494): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[60]
01-07 12:41:00.717+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:00.717+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:00.817+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 1 6
01-07 12:41:00.817+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 2 6
01-07 12:41:00.827+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
01-07 12:41:00.827+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 8 2
01-07 12:41:00.827+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 9 2
01-07 12:41:00.827+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 10 2
01-07 12:41:01.207+0900 E/PKGMGR_CERT( 3533): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
01-07 12:41:01.247+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_make_directory(1601) > mkdir failed. appdir=[/usr/apps/org.example.buildertest/shared], errno=[2][No such file or directory]
01-07 12:41:01.247+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.buildertest/shared]
01-07 12:41:01.247+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.buildertest/shared/res]
01-07 12:41:01.257+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.buildertest/tizen-manifest.xml]
01-07 12:41:01.257+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.buildertest/author-signature.xml]
01-07 12:41:01.257+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.buildertest/signature1.xml]
01-07 12:41:01.257+0900 E/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/share/packages/org.example.buildertest.xml]
01-07 12:41:01.267+0900 D/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1405) > Exist shared/data folder (path:[/opt/usr/apps/org.example.buildertest/shared/data])
01-07 12:41:01.597+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_unregister_package(84) > [smack] app_uninstall(org.example.buildertest), result=[0]
01-07 12:41:01.927+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.buildertest), result=[0]
01-07 12:41:01.937+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest, 5, _), result=[0]
01-07 12:41:01.947+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/shared, 5, _), result=[0]
01-07 12:41:01.947+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/shared/res, 5, _), result=[0]
01-07 12:41:01.997+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: exit_server(724) > exit_server Start
01-07 12:41:02.347+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/shared/data, 2), result=[0]
01-07 12:41:02.357+0900 D/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_get_group_id(1881) > encoding done, len=[28]
01-07 12:41:02.357+0900 D/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_apply_smack(1989) > groupid = [2tPG2gVUuLfxfQvaG6wt2qdbySE=] for shared/trusted.
01-07 12:41:02.637+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/shared/trusted, 1, 2tPG2gVUuLfxfQvaG6wt2qdbySE=), result=[0]
01-07 12:41:02.657+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/bin, 0, org.example.buildertest), result=[0]
01-07 12:41:02.657+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/data, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/lib, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/res, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/cache, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/tizen-manifest.xml, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/author-signature.xml, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/usr/apps/org.example.buildertest/signature1.xml, 0, org.example.buildertest), result=[0]
01-07 12:41:02.667+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/share/packages/org.example.buildertest.xml, 0, org.example.buildertest), result=[0]
01-07 12:41:02.677+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/storage/sdcard/apps/org.example.buildertest, 5, _), result=[0]
01-07 12:41:02.687+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/storage/sdcard/apps/org.example.buildertest/data, 0, org.example.buildertest), result=[0]
01-07 12:41:02.687+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/storage/sdcard/apps/org.example.buildertest/cache, 0, org.example.buildertest), result=[0]
01-07 12:41:02.687+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.buildertest, /opt/storage/sdcard/apps/org.example.buildertest/shared, 5, _), result=[0]
01-07 12:41:02.867+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.buildertest, /opt/storage/sdcard/apps/org.example.buildertest/shared/data, 2), result=[0]
01-07 12:41:02.937+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
01-07 12:41:02.947+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.buildertest, 7), result=[0]
01-07 12:41:03.057+0900 D/rpm-installer( 3533): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
01-07 12:41:03.057+0900 D/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_package_reinstall(3540) > #permission applying success.
01-07 12:41:03.057+0900 D/rpm-installer( 3533): coretpk-installer.c: _coretpk_installer_package_reinstall(3571) > [#]end : _coretpk_installer_package_reinstall
01-07 12:41:03.087+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.087+0900 D/PKGMGR  ( 2414): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.087+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.087+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.117+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.117+0900 D/PKGMGR  ( 2414): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.117+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.117+0900 D/PKGMGR  ( 2414): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.117+0900 D/PKGMGR  ( 2423): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.167+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.167+0900 D/PKGMGR  ( 2494): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.167+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.167+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.167+0900 D/DATA_PROVIDER_MASTER( 2426): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.buildertest] 100
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.167+0900 D/PKGMGR  ( 2426): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.167+0900 D/DATA_PROVIDER_MASTER( 2426): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.buildertest] ok
01-07 12:41:03.227+0900 D/PKGMGR  ( 2290): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.227+0900 D/PKGMGR  ( 2290): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.227+0900 D/AUL_AMD ( 2290): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.buildertest), key(end), value(ok)
01-07 12:41:03.227+0900 D/AUL_AMD ( 2290): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(update), value(ok)
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.237+0900 D/ADD_VIEWER( 2418): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.buildertest] 100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.237+0900 D/W_HOME  ( 2418): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.buildertest key:install_percent val:100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / install_percent / 100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[install_percent] val[100]
01-07 12:41:03.237+0900 D/APPS    ( 2418): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.buildertest
01-07 12:41:03.237+0900 D/APPS    ( 2418): pkgmgr.c: _install_percent(469) >  package(org.example.buildertest) with 100
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.237+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.247+0900 D/ADD_VIEWER( 2418): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.buildertest] ok
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.247+0900 D/W_HOME  ( 2418): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.buildertest key:end val:ok
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.247+0900 D/PKGMGR  ( 2418): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.247+0900 D/APPS    ( 2418): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.buildertest
01-07 12:41:03.247+0900 D/APPS    ( 2418): pkgmgr.c: _end(651) >  Package(org.example.buildertest) : key(update) - val(ok)
01-07 12:41:03.377+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.buildertest_-419981091 / coretpk / org.example.buildertest / end / ok
01-07 12:41:03.377+0900 D/PKGMGR  ( 2494): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.buildertest_-419981091] pkg_type[coretpk] pkgid[org.example.buildertest]key[end] val[ok]
01-07 12:41:03.377+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.377+0900 D/PKGMGR  ( 2494): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.377+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.377+0900 D/PKGMGR  ( 2426): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.387+0900 D/rpm-installer( 3533): rpm-appcore-intf.c: main(246) > ------------------------------------------------
01-07 12:41:03.387+0900 D/rpm-installer( 3533): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
01-07 12:41:03.387+0900 D/rpm-installer( 3533): rpm-appcore-intf.c: main(248) > ------------------------------------------------
01-07 12:41:03.557+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: sighandler(326) > child exit [3533]
01-07 12:41:03.557+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: sighandler(341) > child NORMAL exit [3533]
01-07 12:41:03.637+0900 D/AUL_AMD ( 2290): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
01-07 12:41:03.637+0900 D/AUL_AMD ( 2290): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.buildertest, comp:ui, type:rpm
01-07 12:41:03.657+0900 E/RESOURCED( 2451): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/3533/oom_score_adj failed
01-07 12:41:03.677+0900 E/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 3533
01-07 12:41:03.697+0900 D/PKGMGR  ( 2290): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:03.697+0900 D/PKGMGR  ( 2290): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:03.857+0900 D/APPS    ( 2418): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.buildertest]
01-07 12:41:03.857+0900 D/APPS    ( 2418): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.buildertest]'s item object
01-07 12:41:03.877+0900 D/APPS    ( 2418): db.c: apps_db_remove_item(404) >  Remove the item[org.example.buildertest]
01-07 12:41:03.997+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: exit_server(724) > exit_server Start
01-07 12:41:03.997+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: main(1516) > Quit main loop.
01-07 12:41:04.007+0900 D/PKGMGR_SERVER( 3532): pkgmgr-server.c: main(1524) > package manager server terminated.
01-07 12:41:04.107+0900 D/APPS    ( 2418): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.buildertest], name[buildertest]
01-07 12:41:04.107+0900 D/APPS    ( 2418): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.buildertest]
01-07 12:41:04.177+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
01-07 12:41:04.267+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 101 bytes
01-07 12:41:04.267+0900 D/DATA_PROVIDER_MASTER( 2426): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-07 12:41:04.447+0900 D/BADGE   ( 2426): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 12:41:04.447+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-07 12:41:04.447+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2426, fd: -1
01-07 12:41:04.447+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2426), fd: -1
01-07 12:41:04.447+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-07 12:41:04.447+0900 D/APPS    ( 2418): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.buildertest]
01-07 12:41:04.447+0900 E/DATA_PROVIDER_MASTER( 2426): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-07 12:41:04.447+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
01-07 12:41:04.467+0900 D/COM_CORE( 2426): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-07 12:41:04.467+0900 D/DATA_PROVIDER_MASTER( 2426): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0dbc8 is terminated (NIL packet)
01-07 12:41:04.467+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-07 12:41:04.467+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 101 bytes
01-07 12:41:04.467+0900 D/DATA_PROVIDER_MASTER( 2426): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-07 12:41:04.497+0900 D/BADGE   ( 2426): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 12:41:04.497+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-07 12:41:04.507+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2426, fd: -1
01-07 12:41:04.507+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2426), fd: -1
01-07 12:41:04.507+0900 D/COM_CORE( 2418): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-07 12:41:04.517+0900 D/COM_CORE( 2426): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-07 12:41:04.517+0900 E/DATA_PROVIDER_MASTER( 2426): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-07 12:41:04.517+0900 D/DATA_PROVIDER_MASTER( 2426): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0a6d0 is terminated (NIL packet)
01-07 12:41:04.517+0900 D/DATA_PROVIDER_MASTER( 2426): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-07 12:41:04.617+0900 D/APPS    ( 2418): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.buildertest], name[buildertest]
01-07 12:41:04.757+0900 D/APPS    ( 2418): item.c: item_create(819) >  Icon size after ea_effect (124:127)
01-07 12:41:04.797+0900 D/BADGE   ( 2418): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.buildertest'], count[0]
01-07 12:41:04.817+0900 D/APPS    ( 2418): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
01-07 12:41:04.817+0900 D/APPS    ( 2418): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.test]'s ordering : 1
01-07 12:41:04.817+0900 D/APPS    ( 2418): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.buildertest]'s ordering : 2
01-07 12:41:04.817+0900 D/APPS    ( 2418): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
01-07 12:41:04.847+0900 D/APPS    ( 2418): db.c: apps_db_update_item(374) >  Update the item[org.example.test:1]
01-07 12:41:04.897+0900 D/APPS    ( 2418): db.c: apps_db_insert_item(345) >  Insert the item[org.example.buildertest:2]
01-07 12:41:04.937+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-07 12:41:04.937+0900 D/PKGMGR  ( 2418): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-07 12:41:08.847+0900 D/AUL_AMD ( 2290): amd_request.c: __request_handler(506) > __request_handler: 0
01-07 12:41:08.917+0900 D/AUL_AMD ( 2290): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.buildertest
01-07 12:41:08.997+0900 D/AUL     ( 2290): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 3588, pid = 3590
01-07 12:41:09.017+0900 D/AUL_AMD ( 2290): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
01-07 12:41:09.037+0900 D/AUL_AMD ( 2290): amd_launch.c: _start_app(1803) > process_pool: false
01-07 12:41:09.037+0900 D/AUL_AMD ( 2290): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
01-07 12:41:09.037+0900 D/AUL_AMD ( 2290): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.buildertest
01-07 12:41:09.037+0900 D/AUL_AMD ( 2290): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
01-07 12:41:09.037+0900 D/AUL     ( 2290): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
01-07 12:41:09.047+0900 D/AUL_PAD ( 2313): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.buildertest
01-07 12:41:09.047+0900 D/AUL_PAD ( 2313): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
01-07 12:41:09.047+0900 D/AUL_PAD ( 2313): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 3591 /opt/usr/apps/org.example.buildertest/bin/buildertest
01-07 12:41:09.047+0900 D/AUL_PAD ( 2313): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
01-07 12:41:09.047+0900 D/AUL_PAD ( 3591): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
01-07 12:41:09.057+0900 D/AUL_PAD ( 3591): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
01-07 12:41:09.057+0900 D/AUL_PAD ( 3591): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.buildertest / pkg_type : rpm / app_path : /opt/usr/apps/org.example.buildertest/bin/buildertest 
01-07 12:41:09.157+0900 D/AUL_PAD ( 2313): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
01-07 12:41:09.187+0900 D/AUL_PAD ( 3591): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
01-07 12:41:09.187+0900 D/AUL_PAD ( 3591): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.buildertest/bin/buildertest##
01-07 12:41:09.187+0900 D/AUL_PAD ( 3591): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
01-07 12:41:09.187+0900 D/AUL_PAD ( 3591): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
01-07 12:41:09.187+0900 D/LAUNCH  ( 3591): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.buildertest/bin/buildertest:Platform:launchpad:done]
01-07 12:41:09.207+0900 I/efl-extension( 3591): efl_extension.c: eext_mod_init(39) > Init
01-07 12:41:09.247+0900 I/CAPI_APPFW_APPLICATION( 3591): app_main.c: ui_app_main(701) > app_efl_main
01-07 12:41:09.247+0900 D/LAUNCH  ( 3591): appcore-efl.c: appcore_efl_main(1597) > [buildertest:Application:main:done]
01-07 12:41:09.257+0900 D/AUL_PAD ( 2313): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
01-07 12:41:09.287+0900 D/AUL_PAD ( 2313): sigchild.h: __send_app_launch_signal(112) > send launch signal done
01-07 12:41:09.287+0900 D/AUL_PAD ( 2313): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
01-07 12:41:09.287+0900 D/AUL     ( 2290): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
01-07 12:41:09.287+0900 E/AUL     ( 2290): simple_util.c: __trm_app_info_send_socket(264) > access
01-07 12:41:09.297+0900 D/RESOURCED( 2451): proc-noti.c: recv_str(87) > [recv_str,87] str is null
01-07 12:41:09.297+0900 D/RESOURCED( 2451): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2290
01-07 12:41:09.297+0900 D/RESOURCED( 2451): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.buildertest, pid 3591, type 4 
01-07 12:41:09.337+0900 D/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.buildertest, 3591
01-07 12:41:09.337+0900 D/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.buildertest with pkgname
01-07 12:41:09.347+0900 E/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 380
01-07 12:41:09.347+0900 D/RESOURCED( 2451): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
01-07 12:41:09.787+0900 D/APP_CORE( 3591): appcore-efl.c: __before_loop(1030) > elm_config_preferred_engine_set is not called
01-07 12:41:09.847+0900 D/AUL     ( 3591): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3591 is org.example.buildertest
01-07 12:41:09.857+0900 D/APP_CORE( 3591): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.buildertest/res/locale
01-07 12:41:09.857+0900 D/APP_CORE( 3591): appcore-i18n.c: update_region(74) > *****appcore setlocale=en_GB.UTF-8
01-07 12:41:09.857+0900 D/AUL     ( 3591): app_sock.c: __create_server_sock(141) > pg path - already exists
01-07 12:41:09.867+0900 D/LAUNCH  ( 3591): appcore-efl.c: __before_loop(1048) > [buildertest:Platform:appcore_init:done]
01-07 12:41:09.867+0900 I/CAPI_APPFW_APPLICATION( 3591): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
01-07 12:41:10.297+0900 D/AUL_AMD ( 2290): amd_launch.c: __grab_timeout_handler(1222) > pid(3591) ecore_x_pointer_ungrab
01-07 12:41:10.327+0900 D/AUL_AMD ( 2290): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.buildertest /opt/usr/apps/org.example.buildertest/bin/buildertest
01-07 12:41:10.327+0900 D/RUA     ( 2290): rua.c: rua_add_history(179) > rua_add_history start
01-07 12:41:10.617+0900 D/RUA     ( 2290): rua.c: rua_add_history(247) > rua_add_history ok
01-07 12:41:10.727+0900 E/EFL     ( 3591): eina_module<3591> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-07 12:41:10.807+0900 E/EFL     ( 3591): ecore_evas<3591> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
01-07 12:41:10.897+0900 E/EFL     ( 3591): eina_module<3591> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
01-07 12:41:10.947+0900 E/EFL     ( 3591): elementary<3591> elm_widget.c:4357 elm_widget_type_check() Passing Object: 0xb9626e70 in function: elm_win_alpha_set, of type: 'elm_box' when expecting type: 'elm_win'
01-07 12:41:11.307+0900 D/W_HOME  ( 2418): main.c: _window_focus_out_cb(869) > focus out
01-07 12:41:11.307+0900 D/W_HOME  ( 2418): main.c: _pause_cb(600) > Paused
01-07 12:41:11.427+0900 D/W_HOME  ( 2418): page.c: page_focus(696) > focus set to 0xb9833cc8
01-07 12:41:11.427+0900 W/W_HOME  ( 2418): main.c: _pause_cb(613) > clock/widget paused
01-07 12:41:11.427+0900 D/W_HOME  ( 2418): clock_view.c: clock_view_event_handler(843) > event:10002 received
01-07 12:41:11.427+0900 D/W_HOME  ( 2418): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb96cb8b0 is paused
01-07 12:41:11.427+0900 E/APPS    ( 2418): apps_main.c: _window_focus_out_cb(313) >  win[20971527], ev->win[20971523]
01-07 12:41:11.507+0900 D/DATA_PROVIDER_MASTER( 2426): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2418 is paused
01-07 12:41:11.507+0900 D/DATA_PROVIDER_MASTER( 2426): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
01-07 12:41:11.547+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1334) > Receive msg from clien msg_domain=0 msg_id=0 size=9
01-07 12:41:11.547+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1335) >  ########## data : mc_pause
01-07 12:41:11.547+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1340) > ##### mc_pause
01-07 12:41:11.547+0900 D/LAUNCH  ( 3591): appcore-efl.c: __before_loop(1066) > [buildertest:Application:create:done]
01-07 12:41:11.587+0900 D/APP_CORE( 3591): appcore-efl.c: __check_wm_rotation_support(765) > Disable window manager rotation
01-07 12:41:11.737+0900 D/APP_CORE( 3591): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
01-07 12:41:11.737+0900 D/APP_CORE( 3591): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
01-07 12:41:11.927+0900 D/APP_CORE( 3591): appcore.c: __aul_handler(423) > [APP 3591]     AUL event: AUL_START
01-07 12:41:11.937+0900 D/APP_CORE( 3591): appcore-efl.c: __do_app(471) > [APP 3591] Event: RESET State: CREATED
01-07 12:41:11.937+0900 D/APP_CORE( 3591): appcore-efl.c: __do_app(497) > [APP 3591] RESET
01-07 12:41:11.937+0900 D/LAUNCH  ( 3591): appcore-efl.c: __do_app(499) > [buildertest:Application:reset:start]
01-07 12:41:11.937+0900 I/CAPI_APPFW_APPLICATION( 3591): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
01-07 12:41:11.937+0900 D/APP_SVC ( 3591): appsvc.c: __set_bundle(161) > __set_bundle
01-07 12:41:11.937+0900 D/LAUNCH  ( 3591): appcore-efl.c: __do_app(506) > [buildertest:Application:reset:done]
01-07 12:41:12.077+0900 I/APP_CORE( 3591): appcore-efl.c: __do_app(512) > Legacy lifecycle: 0
01-07 12:41:12.077+0900 I/APP_CORE( 3591): appcore-efl.c: __do_app(514) > [APP 3591] Initial Launching, call the resume_cb
01-07 12:41:12.077+0900 I/CAPI_APPFW_APPLICATION( 3591): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
01-07 12:41:12.077+0900 D/APP_CORE( 3591): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
01-07 12:41:12.097+0900 D/APP_CORE( 3591): appcore.c: __prt_ltime(183) > [APP 3591] first idle after reset: 3256 msec
01-07 12:41:12.097+0900 W/W_HOME  ( 2418): main.c: _window_visibility_cb(796) > Window [0x1400003] is now visible(1)
01-07 12:41:12.097+0900 D/APP_CORE( 2418): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1400003 fully_obscured 1
01-07 12:41:12.097+0900 D/APP_CORE( 2418): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
01-07 12:41:12.097+0900 D/APP_CORE( 2418): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
01-07 12:41:12.097+0900 D/APP_CORE( 2418): appcore-efl.c: __do_app(471) > [APP 2418] Event: PAUSE State: RUNNING
01-07 12:41:12.097+0900 D/APP_CORE( 2418): appcore-efl.c: __do_app(543) > [APP 2418] PAUSE
01-07 12:41:12.107+0900 D/APP_CORE( 3591): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
01-07 12:41:12.107+0900 D/APP_CORE( 3591): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
01-07 12:41:12.107+0900 D/APP_CORE( 3591): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
01-07 12:41:12.107+0900 D/APP_CORE( 3591): appcore-efl.c: __do_app(471) > [APP 3591] Event: RESUME State: RUNNING
01-07 12:41:12.107+0900 D/LAUNCH  ( 3591): appcore-efl.c: __do_app(566) > [buildertest:Application:resume:start]
01-07 12:41:12.107+0900 D/LAUNCH  ( 3591): appcore-efl.c: __do_app(580) > [buildertest:Application:resume:done]
01-07 12:41:12.107+0900 D/LAUNCH  ( 3591): appcore-efl.c: __do_app(582) > [buildertest:Application:Launching:done]
01-07 12:41:12.107+0900 D/APP_CORE( 3591): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
01-07 12:41:12.107+0900 E/APP_CORE( 3591): appcore-efl.c: __trm_app_info_send_socket(234) > access
01-07 12:41:12.117+0900 I/CAPI_APPFW_APPLICATION( 2418): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
01-07 12:41:12.117+0900 D/W_HOME  ( 2418): main.c: _pause_cb(600) > Paused
01-07 12:41:12.117+0900 E/W_HOME  ( 2418): main.c: _pause_cb(603) > paused already
01-07 12:41:12.117+0900 D/APP_CORE( 2418): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
01-07 12:41:12.117+0900 E/APP_CORE( 2418): appcore-efl.c: __trm_app_info_send_socket(234) > access
01-07 12:41:12.207+0900 D/RESOURCED( 2451): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2418, type = 2
01-07 12:41:12.207+0900 D/AUL_AMD ( 2290): amd_launch.c: __e17_status_handler(1939) > pid(3591) status(3)
01-07 12:41:12.227+0900 D/RESOURCED( 2451): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 3591, type = 0
01-07 12:41:12.227+0900 D/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 3591
01-07 12:41:12.227+0900 I/RESOURCED( 2451): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 3591, oom : 200
01-07 12:41:12.227+0900 E/RESOURCED( 2451): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
01-07 12:41:17.197+0900 D/APP_CORE( 2418): appcore-efl.c: __do_app(471) > [APP 2418] Event: MEM_FLUSH State: PAUSED
01-07 12:41:19.897+0900 I/GESTURE ( 2224): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
01-07 12:41:19.987+0900 D/EFL     ( 3591): ecore_x<3591> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16886893 button=1
01-07 12:41:19.987+0900 D/EFL     ( 3591): ecore_x<3591> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16886982 button=1
01-07 12:41:19.997+0900 E/EFL     ( 3591): eina_module<3591> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-07 12:41:21.077+0900 I/AUL_PAD ( 2313): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3591 pgid = 3591
01-07 12:41:21.077+0900 I/AUL_PAD ( 2313): sigchild.h: __sigchild_action(123) > dead_pid(3591)
01-07 12:41:21.077+0900 D/AUL_PAD ( 2313): sigchild.h: __send_app_dead_signal(81) > send dead signal done
01-07 12:41:21.077+0900 I/AUL_PAD ( 2313): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
01-07 12:41:21.087+0900 I/AUL_PAD ( 2313): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
01-07 12:41:21.127+0900 I/AUL_AMD ( 2290): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3591
01-07 12:41:21.127+0900 D/AUL_AMD ( 2290): amd_key.c: _unregister_key_event(161) > ===key stack===
01-07 12:41:21.127+0900 D/AUL     ( 2290): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
01-07 12:41:21.127+0900 E/AUL     ( 2290): simple_util.c: __trm_app_info_send_socket(264) > access
01-07 12:41:21.147+0900 D/AUL_AMD ( 2290): amd_launch.c: __e17_status_handler(1939) > pid(2418) status(3)
01-07 12:41:21.157+0900 D/RESOURCED( 2451): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2418, type = 0
01-07 12:41:21.157+0900 D/RESOURCED( 2451): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2418
01-07 12:41:21.157+0900 D/RESOURCED( 2451): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2418, appname = (null)
01-07 12:41:21.157+0900 D/RESOURCED( 2451): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2418
01-07 12:41:21.167+0900 D/STARTER ( 2407): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3591)
01-07 12:41:21.287+0900 D/W_HOME  ( 2418): main.c: _window_focus_in_cb(848) > focus in
01-07 12:41:21.287+0900 D/W_HOME  ( 2418): main.c: _resume_cb(564) > Resumed
01-07 12:41:21.287+0900 D/APPS    ( 2418): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
01-07 12:41:21.337+0900 D/W_HOME  ( 2418): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
01-07 12:41:21.337+0900 E/efl-extension( 2418): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb96cb010, elm_scroller, _activated_obj : 0xb96cb010, activated : 1
01-07 12:41:21.337+0900 W/W_HOME  ( 2418): main.c: _resume_cb(589) > clock/widget resumed
01-07 12:41:21.337+0900 D/W_HOME  ( 2418): clock_view.c: clock_view_event_handler(843) > event:10004 received
01-07 12:41:21.337+0900 D/W_HOME  ( 2418): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
01-07 12:41:21.337+0900 D/W_HOME  ( 2418): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb96cb8b0 is resumed
01-07 12:41:21.337+0900 E/APPS    ( 2418): apps_main.c: _window_focus_in_cb(293) >  win[20971527], ev->win[20971523]
01-07 12:41:21.337+0900 D/W_HOME  ( 2418): main.c: _dead_cb(542) > PID(3591) is dead
01-07 12:41:21.337+0900 E/W_HOME  ( 2418): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
01-07 12:41:21.337+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1334) > Receive msg from clien msg_domain=0 msg_id=0 size=10
01-07 12:41:21.337+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1335) >  ########## data : mc_resume
01-07 12:41:21.337+0900 D/IDLE-CLOCK-DIGITAL( 2457): clock_view.c: _ecore_evas_msg_parent_handle(1338) > ##### mc_resume
01-07 12:41:21.357+0900 D/DATA_PROVIDER_MASTER( 2426): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2418 is resumed
01-07 12:41:21.357+0900 D/DATA_PROVIDER_MASTER( 2426): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
01-07 12:41:21.407+0900 W/CRASH_MANAGER( 3601): worker.c: worker_job(1189) > 1103591627569148376048
