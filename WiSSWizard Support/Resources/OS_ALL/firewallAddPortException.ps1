
param($protocol,$port,$programpath)
netsh firewall add portopening $protocol $port `""$programpath`""
