@ECHO OFF
SignTool.exe sign /a /v /tr http://timestamp.globalsign.com/tsa/r6advanced1 /td SHA256 /fd sha256 "D:\Work\01.Projects\01.Smart_Interface\Resources\usbdriver\x64\ziveusb.sys"
inf2cat_win11\inf2cat.exe /driver:D:\Work\01.Projects\01.Smart_Interface\Resources\usbdriver /os:7_X86,7_X64,2000,XP_X86,XP_X64,Vista_X86,Vista_X64,10_NI_X64,10_CO_X64,10_VB_X86,10_VB_X64
SignTool.exe sign /a /v /tr http://timestamp.globalsign.com/tsa/r6advanced1 /td SHA256 /fd sha256 "D:\Work\01.Projects\01.Smart_Interface\Resources\usbdriver\zive.cat"
PAUSE