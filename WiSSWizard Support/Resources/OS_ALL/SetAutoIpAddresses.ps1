param ($caption)
$adapter = Get-WmiObject "Win32_NetworkAdapterConfiguration" | Where {$_.IPEnabled -eq "TRUE" -and $_.Caption -eq $caption}
$adapter.EnableDHCP()
