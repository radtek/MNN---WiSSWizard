param($localGroupName) 


$computerName = "$env:computername" 

$computer = [ADSI]"WinNT://$computerName,computer" 
$computer.psbase.Children.Remove("WinNT://$computerName/$localGroupName")  
 
