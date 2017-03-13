
$NICs = Get-WmiObject "Win32_NetworkAdapterConfiguration" | Where {$_.IPEnabled -eq "TRUE"}
foreach ($NIC in $NICs)
{ 
"Current configure for $($NIC.Caption)" 
"Current IP address: $($NIC.IpAddress)" 
"Current Subnet mask: $($NIC.IpSubnet)" 
"Default gateway: $($NIC.DefaultIPGateway)"
"" 
"DNS Domain: $($NIC.DNSDomain)"
"DNS Server: $($NIC.DNSServerSearchOrder)"
"-------------------------------------------------------" 
}

