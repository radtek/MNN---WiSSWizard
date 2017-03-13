
$RegExplorer2 = Get-ItemProperty -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Network
$RegExplorer3 = Get-ItemProperty -Path HKLM:\SYSTEM\CurrentControlSet\Services\Netlogon\Parameters
"Maximum Password Age : $($RegExplorer3.maximumpasswordage)"
"Minimum Password Length : $($RegExplorer2.MinPwdLen)"

$domain = [ADSI]"WinNT://$env:userdomain" 
$MinPassLen = @{Name="Minimum Password Length (Chars)";Expression={$_.MinPasswordLength}} 
$MinPassAge = @{Name="Minimum Password Age (Days)";Expression={$_.MinPasswordAge.value/86400}} 
$MaxPassAge = @{Name="Maximum Password Age (Days)";Expression={$_.MaxPasswordAge.value/86400}} 
$PassHistory = @{Name="Enforce Password History (Passwords remembered)";Expression={$_.PasswordHistoryLength}} 
$PasswordComplex = @{Name="Password must meet complexity requirements";Expression={"1"}} 
$domain | Select-Object $MinPassLen,$MinPassAge,$MaxPassAge,$PassHistory,$PasswordComplex
