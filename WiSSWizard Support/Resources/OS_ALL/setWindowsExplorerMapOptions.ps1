param($RegisterPath, $Keyname, $Value)

Set-ItemProperty -path $RegisterPath -name $Keyname -value $Value
