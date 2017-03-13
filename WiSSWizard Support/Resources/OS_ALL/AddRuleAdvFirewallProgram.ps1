param ($name,$direction,$programPath)
netsh advfirewall firewall add rule name="$name" dir="$direction" program="$programPath" action=allow