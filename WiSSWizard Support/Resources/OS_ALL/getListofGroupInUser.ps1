
param ($strUserName)

$strUser = get-qaduser -SamAccountName $strUserName
$strUser.memberof
