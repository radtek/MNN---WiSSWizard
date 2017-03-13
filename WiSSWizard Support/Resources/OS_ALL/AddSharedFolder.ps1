param($FolderPath,$ShareName,$SimultaneousUserLimit,$Description)
$Shares=[WMICLASS]”WIN32_Share”
$Shares.Create("$FolderPath","$ShareName",0,$SimultaneousUserLimit,$Description)
