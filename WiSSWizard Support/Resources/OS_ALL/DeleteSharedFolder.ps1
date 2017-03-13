function deleteShare
{
param($ShareName)
$Shares=[WMICLASS]”WIN32_Share”
$Shares.Delete()| where { $Shares.Name -eq "$ShareName"} 
}