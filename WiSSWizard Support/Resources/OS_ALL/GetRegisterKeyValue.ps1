param($RegisterPath, $Keyname)

#get-itemproperty -path "$RegisterPath" -name "$Keyname"

try
   {
        $exists = Get-ItemProperty $RegisterPath $Keyname -ErrorAction SilentlyContinue
        if (($exists -eq $null) -or ($exists.Length -eq 0))
        {
            return $false
	}
        else
        {
            get-itemproperty -path "$RegisterPath" -name "$Keyname"
            return $true
	    
        }
    }
    catch
    {
        return $false
    }