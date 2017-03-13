param($RegisterPath, $Keyname, $Value, $PropertyType)

 try
    {
        $exists = Get-ItemProperty $RegisterPath $Keyname -ErrorAction SilentlyContinue
        if (($exists -eq $null) -or ($exists.Length -eq 0))
        {
            #false
	    New-Item -Path $RegisterPath 
            New-ItemProperty $RegisterPath -Name $Keyname -Value $Value -PropertyType $PropertyType 
            #Set-ItemProperty -path $RegisterPath -name $Keyname -value $Value
        }
        else
        {
            #true
	    Set-ItemProperty -path $RegisterPath -name $Keyname -value $Value	
        }
    }
    catch
    {
        return $false
    }