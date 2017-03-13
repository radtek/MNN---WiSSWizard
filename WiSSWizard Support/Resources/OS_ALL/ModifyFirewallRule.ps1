
param ($oldRuleName,$newRuleName,$enable,$direction,$protocol,$port,$action)
netsh advfirewall firewall set rule name="$oldRuleName" new name="$newRuleName" enable="$enable" dir="$direction" protocol="$protocol" localport="$port" action="$action"
