
param($program,$protocol,$port,$programPath)


if($program -eq "RemoteDesktop")
{
	netsh firewall set service remoteadmin disable
	
}
else
{
	if($program -eq "null" -and $programPath -eq "null")
	{
		
		netsh firewall delete portopening protocol = $protocol port = $port
	}
	if($program -eq "null" -and $protocol -eq "null" -and $port -eq "null")
	{	
		netsh firewall delete allowedprogram "$programPath"		
	}
}
