
param($program,$programPath,$pcAnywhere)
#write-host netsh firewall add portopening $protocol $port `""$program`"" enable

if($program -eq "RemoteDesktop")
{
	netsh firewall set service remoteadmin enable
	
}
else
{
	
		if($pcAnywhere -eq "null")
		{
			netsh firewall add allowedprogram "$programPath" `""$program`"" enable
		}
		else
		{
			netsh firewall add allowedprogram "$programPath\awhost32.exe" `""$program`"" enable
		}
}	

