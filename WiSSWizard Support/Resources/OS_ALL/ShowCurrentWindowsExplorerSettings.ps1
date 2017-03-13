
$RegExplorer1 =  Get-ItemProperty -Path HKCU:\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced 
$RegExplorer2 =  Get-ItemProperty -Path HKCU:\Software\Microsoft\Windows\CurrentVersion\Explorer\CabinetState 
$RegExplorer3 = Get-ItemProperty -Path HKLM:\SYSTEM\CurrentControlSet\Services\Cdrom
"Autoplay is set to : $($RegExplorer3.Autorun)"
"Show the content of system folder is set to : $($RegExplorer1.WebViewBarricade)"
"Display the full path in the address bar is set to : $($RegExplorer2.FullPathAddress)"
"Show hidden files and folders is set to : $($RegExplorer1.Hidden)" 
"Automatic search for network folders and printers is set to : $($RegExplorer1.NoNetCrawling)" 
"Hide File extensions is set to : $($RegExplorer1.HideFileExt)" 
"Show system files and folders is set to : $($RegExplorer1.ShowSuperHidden)" 
"The View settings for each folder is set to : $($RegExplorer1.ClassicViewState)"
"Show Encrypted or compressed NTFS files in color is set to : $($RegExplorer1.ShowCompColor)"



