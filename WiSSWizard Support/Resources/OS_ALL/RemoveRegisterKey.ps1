param($RegisterPath, $Keyname)

remove-itemproperty -path $RegisterPath -name $Keyname
