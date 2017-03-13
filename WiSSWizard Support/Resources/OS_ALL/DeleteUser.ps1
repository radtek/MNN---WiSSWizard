Param($UserName)

$name ="localhost"

$strComputer = $env:COMPUTERNAME  

$strUser =  $env:COMPUTERNAME + "/" + $name 
  
$computer = [ADSI]("WinNT://" + $strComputer + ",computer")  

$computer.Delete("user",$UserName)