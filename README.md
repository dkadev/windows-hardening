# WINDOWS 10 HARDENING GUIDE
Guide and compilation of tools for Windows 10 hardening.
(ALTHOUGH IS A PUBLIC REPO ITS BEEN CREATED FOR PERSONAL USE, SO IF YOU WANT TO TRY THIS I'M NOT RESPONSIBLE FOR USE AND CONSEQUENCES)

## Step by step of a fresh clean Windows 10 Enterprise LTSC installation

Install offline

Set UAC

Change explorer view options

Uninstall telemetry and tasks

    Destroy-Windows-10-Spying
	  Windows10Debloater

Disable services

    -Web account manager
    -NetBios over TCP / IP helper application
    -IP helper application (if we don't use IPV6, out)
    -Routing and remote access
    -Remote registration
    -Windows biometric service
    -Radio management service
    -Push message routing service .... (WAP)
    -Geo-location service
    -Windows error reporting service
    -Remote desktop services
    -Telephony
    -Use of data
    -Xbox

Block hosts

	Open notepad as admin
	/windows/system32/drivers/etc/hosts
  

Configure NCSI

	WindowsSpyblocker

	\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\NlaSvc\Parameters\Internet


Configure privacy and system (share experience)


Disable multicast

	[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\DNSClient]
	"EnableMulticast"=dword:00000000

Change DNS to Quad9 and Cloudfare
    
    9.9.9.9 and 1.1.1.1

Windows Activation

I use KMS38 from https://gitlab.com/massgrave/microsoft-activation-scripts

Change device name

Windows Update

Enable Bitlocker

Recommended programs

	-7zip
	-Brave
	-VLC
	-Notepad++
	-Sublime text
	-KeePass
	-Git

Autoruns
