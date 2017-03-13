$service = "IISADMIN" 	#Service to monitor
$b = get-wmiobject win32_service -Filter "Name = '$service'"
	if ($b.state -eq "stopped")
	{
	$b.startservice()	
	}

