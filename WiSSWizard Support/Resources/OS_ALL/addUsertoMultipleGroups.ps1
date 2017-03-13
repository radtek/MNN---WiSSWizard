Param(
   [string[]]$group,
   [string]$user,
   [string]$ou,
   [string]$domain,
   [switch]$whatif,
   [switch]$help,
   [switch]$debug
) #end param

Function Get-ScriptHelp
{
 "Add-UserToGroups.ps1 adds a user to one or more groups. User and group must be in same OU"
 "Add-UserToGroups.ps1 -user cn=myuser -group cn=mygroup -ou ou=myou -domain 'dc=nwtraders,dc=com'"
  "Add-UserToGroups.ps1 -user cn=myuser -group cn=mygroup1,cn=mygroup2 -ou ou=myou -domain 'dc=nwtraders,dc=com'"
 "Add-UserToGroups.ps1 -user cn=myuser -group cn=mygroup -ou ou=myou -domain 'dc=nwtraders,dc=com' -whatif"
} # end function Get-ScriptHelp

Function Add-UserToGroups
{
 Param(
   [string[]]$group,
   [string]$user,
   [string]$ou,
   [string]$domain
 ) #end param
 $ads_Property_Append = 3
 ForEach($g in $group)
 {
   write-debug "Connecting to group: LDAP://$g,$ou,$domain" 
   $de = [adsi]"LDAP://$g,$ou,$domain"
    write-debug "Putting user: $user,$ou,$domain"
   $de.putex($ads_Property_Append,"member", @("$user,$ou,$domain"))
   $de.SetInfo()
   
  } #end foreach
} # end function Add-UserToGroups

Function Get-Whatif
{
  Param(
   [string[]]$group,
   [string]$user,
   [string]$ou,
   [string]$domain
 ) #end param
 ForEach($g in $group)
  {
   "WHATIF: Add user $user,$ou,$domain to $g,$ou,$domain" 
  } #end foreach
} #end function Get-Whatif

# *** Entry Point to script ***
if($debug) { $debugPreference = "continue" }
if(-not($user -and $group -and $ou -and $domain)) 
  { throw ("user group ou and domain required") }
if($whatif) { Get-Whatif -user $user -group $group -ou $ou -domain $domain ; exit }
if($help) { Get-Scripthelp ; exit }

 Write-Debug "Adding user to group ..."
 Write-Debug "Calling Add-UserToGroups function."
 Write-Debug "passing: user $user group $group ou $ou domain $domain"

Add-UserToGroups -user $user -group $group -ou $ou -domain $domain