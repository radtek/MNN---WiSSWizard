
param ($GlobalGroup)
$Domain = "INTRANET.STARREN.NL"
net localgroup "Remote Desktop Users" "$Domain\$GlobalGroup" /Add 
