	param($RegisterPath, $Keyname, $Value)

    try
    {
        $exists = Get-ItemProperty $RegisterPath $Keyname -ErrorAction SilentlyContinue
#        Write-Host "Test-RegistryValue: $exists"        
	$str = "=$Value"

	if ($exists -match $str)
        {
            return $true
        }
        else
        {
            return $false
        }
    }
    catch
    {
        return $false
    }


