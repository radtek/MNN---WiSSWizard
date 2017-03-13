$computerName = '' #default localhost

  
if ($computerName -eq "") {$computerName = "$env:computername"}  
$computer = [ADSI]"WinNT://$computerName,computer"  
$computer.psbase.Children | Where-Object { $_.psbase.schemaclassname -eq 'user' } | Format-Table Name -autoSize 

