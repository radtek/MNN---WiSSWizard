param($ruleName,$direction,$protocol,$port)
netsh advfirewall firewall add rule name="$ruleName" dir="$direction" protocol="$protocol" localport="$port" action=allow
