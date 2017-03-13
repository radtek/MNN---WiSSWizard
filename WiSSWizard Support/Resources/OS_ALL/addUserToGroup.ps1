param($name,$toGroup) 

$strDomain = "localhost"  
$strComputer = $env:COMPUTERNAME  

$strUser =  $env:COMPUTERNAME + "/" + $name 
  
$computer = [ADSI]("WinNT://" + $strComputer + ",computer")  
$group = $computer.psbase.children.find($toGroup)  

$group.Name  

function ListAdministrators  
{$members = $group.psbase.invoke("Members") | %{$_.GetType().InvokeMember("Name",'GetProperty',$null,$_,$null)}  
$members}  

   
$group.Add("WinNT://" + $strDomain + "/" + $strUser)  
 
ListAdministrators
