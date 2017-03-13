param($computer="localhost", $user,$fullname,$description,$group,$password,$CNL,$PCC,$PNE,$AD)

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
	}
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


# Creeert een groep als die er nog niet is
$Group = $objOu.Create("Group", $groupCheck)

$Group.SetInfo()

$Group.Description = $groupCheck

$Group.SetInfo()

# voeg de aangemaakte user toe aan de groep
$Group.Add($objUser.Path)

$ComputerName = $env:COMPUTERNAME

$Group.Add("WinNT://$ComputerName/$user")







