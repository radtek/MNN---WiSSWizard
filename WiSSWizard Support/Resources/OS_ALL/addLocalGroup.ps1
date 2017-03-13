param($localGroupName, $description)
  
$computerName = ''
  
if ($computerName -eq "") {$computerName = "$env:computername"}  
  
if([ADSI]::Exists("WinNT://$computerName,computer")) {  
  
    $computer = [ADSI]"WinNT://$computerName,computer"  
  
    $localGroup = $computer.Create("group",$localGroupName)  
    $localGroup.SetInfo()  
    $localGroup.description = [string]$description  
    $localGroup.SetInfo()  
}