
param($Group) 
$group =[ADSI]"WinNT://./$Group" 
$members = @($group.psbase.Invoke("Members")) 
$members | foreach {$_.GetType().InvokeMember("Name", 'GetProperty', $null, $_, $null)} 
