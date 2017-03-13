param($computer="localhost", $user,$fullname,$description,[string[]]$group,$password)

$objOu = [ADSI]"WinNT://$computer"

$objUser = $objOU.Create("User", $user)

$objUser.setpassword($password)

$objUser.SetInfo()

$objUser.Description = $description

$objUser.FullName = $fullname

$objUser.SetInfo()

$objuser.userflags = 65536 -bor 64

$objUser.SetInfo()

# Creeert een groep als die er nog niet is
$Group = $objOu.Create("Group", $group)

$Group.SetInfo()

$Group.Description = $group

$Group.SetInfo()

# voeg de aangemaakte user toe aan de groep
#$Group.Add($objUser.Path)

$ComputerName = $env:COMPUTERNAME

$Group.Add("WinNT://$ComputerName/$user")






