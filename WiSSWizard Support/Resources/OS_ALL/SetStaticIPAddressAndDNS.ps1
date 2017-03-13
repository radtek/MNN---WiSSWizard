
param ($staticIp,$subnetMask,$gateway,$caption)

$adapter = Get-WmiObject "Win32_NetworkAdapterConfiguration" | Where {$_.IPEnabled -eq "TRUE" -and $_.Caption -eq $caption}
$adapter.EnableStatic($staticIp,$subnetMask)
$adapter.SetGateways($gateway,[UInt16] 1)
