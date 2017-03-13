## ===================================================================== 
## Description : Add a New IIS 7.0 Web Site 
##             : Uses IIS 7.0 PowerShell Provider
## Author      : Man Nguyen
## Date        : 19/06/2012 
## Input       : -siteName 
##               -protocol 
##               -ipAddress 
##               -port 
##               -location
## Output      :  
## Usage       : PS> .\Add-IIS7WebSite -siteName "NewWebsite" -protocol "http" -ipAddress "127.0.0.1" -port 80 -location c:\inetpub\wwwroot\NewWebsite
## Notes       : Credit to Jeong's Blog at http://blogs.iis.net/jeonghwan/default.aspx
## Tag         : IIS
## ===================================================================== 

param
($siteName,$protocol,$port,$ipAddress,[switch]$hostHeader,[switch]$applicationPool,$location)	
	New-Website -Name $siteName -protocol $protocol -IPAddress $ipAddress -Port $port -HostHeader $hostHeader -ApplicationPool $applicationPool -physicalPath $location
