
param($name,$fromGroup) 

$strDomain = "localhost"  
$strComputer = $env:COMPUTERNAME  

$strUser =  $env:COMPUTERNAME + "/" + $name 
  
$computer = [ADSI]("WinNT://" + $strComputer + ",computer")  
$group = $computer.psbase.children.find($fromGroup)  

$group.Name  

function ListAdministrators  
{$members = $group.psbase.invoke("Members") | %{$_.GetType().InvokeMember("Name",'GetProperty',$null,$_,$null)}  
$members}  

   
$group.Remove("WinNT://" + $strDomain + "/" + $strUser)  
 
ListAdministrators
