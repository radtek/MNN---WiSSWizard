#param($Group) 
$group =[ADSI]"WinNT://./Remote Desktop Users" 
$members = @($group.psbase.Invoke("Members")) 
$members | foreach {$_.GetType().InvokeMember("Name", 'GetProperty', $null, $_, $null)} 
