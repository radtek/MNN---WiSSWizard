param($computer="localhost", $user,$fullname,$description,[string[]]$group,$password,$CNL,$PCC,$PNE,$AD)
#CNL = ChangePwNextLogon
#PCC = PasswordCantBeChanged
#PNE = PasswordNeverExpires
#AD  = AccountDisabled
$groupCheck
$b = "<none>"
$d = $group.CompareTo($b)

if($d -ne 0)
{
	$groupCheck = $group

}
trap [Exception] { 
     # write-host
      #write-error $("TRAPPED: " + $_.Exception.GetType().FullName); 
      #write-error $("TRAPPED: " + $_.Exception.Message); 
      continue; 
   }
#$objOu = [ADSI]"WinNT://$computer"
$objOu = [ADSI]"WinNT://$env:computername,computer"

$objUser = $objOU.Create("User", $user)

$objUser.setpassword($password)

$objUser.SetInfo()

$objUser.Description = $description

$objUser.FullName = $fullname

$objUser.SetInfo()

	if($CNL -eq 0 -and $PCC -eq 0 -and $PNE -eq 0 -and $AD -eq 0 )        #0000
	{
	# do nothing
	}e
	elseif($CNL -eq 0 -and $PCC -eq 0 -and $PNE -eq 0 -and $AD -eq 1 )    #0001    
	{
 	  $objuser.userflags = 2
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 0 -and $PNE -eq 1 -and $AD -eq 0 )    #0010
	{
 	  $objuser.userflags = 65536
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 0 -and $PNE -eq 1 -and $AD -eq 1 )    #0011
	{
 	  $objuser.userflags = 2 -bor 65536
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 1 -and $PNE -eq 0 -and $AD -eq 0 )    #0100
	{
 	  $objuser.userflags = 64
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 1 -and $PNE -eq 0 -and $AD -eq 1 )    #0101
	{
 	  $objuser.userflags = 64 -bor 2
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 1 -and $PNE -eq 1 -and $AD -eq 0 )    #0110
	{
 	  $objuser.userflags = 64 -bor 65536
          $objUser.SetInfo()
	}
	elseif($CNL -eq 0 -and $PCC -eq 1 -and $PNE -eq 1 -and $AD -eq 1 )    #0111
	{
 	  $objuser.userflags = 2 -bor 64 -bor 65536
          $objUser.SetInfo()
	}
	elseif($CNL -eq 1 -and $PCC -eq 0 -and $PNE -eq 0 -and $AD -eq 0 )    #1000
	{
 	  $objuser.PasswordExpired = 1 
          $objUser.SetInfo()
	}
	elseif($CNL -eq 1 -and $PCC -eq 0 -and $PNE -eq 0 -and $AD -eq 1 )    #1001
	{
 	  $objuser.PasswordExpired = 1 
          $objUser.SetInfo() 	  
	  $objuser.userflags = 2
          $objUser.SetInfo()
	}
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
   $de = [ADSI]"LDAP://$g,$ou,$domain"
   $de.putex($ads_Property_Append,"member", @("$user,$ou,$domain"))
   $de.SetInfo()   
  }
}

# Creates a group if there is not
$Group = $objOu.Create("Group", $groupCheck)

$Group.SetInfo()

$Group.Description = $groupCheck

$Group.SetInfo()

# add the created user to the group
Add-UserToGroups -user $user -group $group -ou $objOu -domain $computer
#$Group.Add($objUser.Path)
#$ComputerName = $env:COMPUTERNAME
#$Group.Add("WinNT://$ComputerName/$user")







