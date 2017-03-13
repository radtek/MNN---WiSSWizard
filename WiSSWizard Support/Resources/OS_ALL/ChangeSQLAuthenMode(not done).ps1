# Connect to the instance using SMO
$s = new-object ('Microsoft.SqlServer.Management.Smo.Server') 'MyServer\MyInstance'
[string]$nm = $s.Name
[string]$mode = $s.Settings.LoginMode

write-output "Instance Name: $nm"
write-output "Login Mode: $mode"

#Change to Mixed Mode
$s.Settings.LoginMode = [Microsoft.SqlServer.Management.SMO.ServerLoginMode]::Mixed

# Make the changes
$srv.Alter()