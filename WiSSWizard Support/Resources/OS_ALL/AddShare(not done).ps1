#region ****************************** Execution started - TreeNode: Shares ******************************
function func_Shares()
{
Add-AdminConsoleShareNode
}

function action()
{
param(
	[string[]]$ComputerName,
	[string]$FolderPath,
	[string]$ShareName,
	[uint32]$SimultaneousUserLimit = 10,
	[string]$Description = $null,
	[bool]$PasswordProtect = $false
)

#region Password Management Functions

function global:Get-Password {
	param(
		$InputObject = $null,
		[Switch]$AsPlainText,
		[Switch]$Force
	)

	begin {
		if ($AsPlainText -and (-not $Force)) {
			throw 'Get-Password: The system cannot protect plain text output.  To suppress this warning and get the password as plain text, reissue the command specifying the Force parameter.'
		}
	}
	process {
		if ((-not $InputObject) -and (-not $_)) {
			$InputObject = Read-Host -AsSecureString -Prompt 'Password'
		}
		if ($InputObject -and $_) {
			throw $(Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'InputObjectNotBound')
		} elseif ($InputObject -or $_) {
			$processObject = $(if ($InputObject) {$InputObject} else {$_})
			if ($processObject -is [System.Security.SecureString]) {
				$secureStringPassword = $processObject
			} elseif ($processObject.Password -is [System.Security.SecureString]) {
				$secureStringPassword = $processObject.Password
			} elseif ($processObject.Credential.Password -is [System.Security.SecureString]) {
				$secureStringPassword = $processObject.Credential.Password
			} else {
				throw $((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'CannotConvertArgumentNoMessage') -f $null,'InputObject',$null,$null,$null,$null,((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'CannotConvertArgument') -f $null,'InputObject','System.Management.Automation.PSCredential',$null,$null,$null,$_.ToString(),$null))
			}
			if ($AsPlainText -and $Force) {
				$bstrPassword = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($secureStringPassword)
				$plainTextPassword = [Runtime.InteropServices.Marshal]::PtrToStringAuto($bstrPassword)
				[Runtime.InteropServices.Marshal]::ZeroFreeBSTR($bstrPassword)
				$plainTextPassword
			} else {
				$secureStringPassword
			}
		}
	}
}

function global:Compare-Password {
	param (
		[System.Security.SecureString]$ReferencePassword,
		[System.Security.SecureString]$DifferencePassword
	)

	begin {
		if (-not $ReferencePassword) {
			Write-Host -ForegroundColor White -Object "function Compare-Password at command pipeline position $($MyInvocation.PipelinePosition)"
			Write-Host 'Supply values for the following parameters:'
			if ($result = Read-Host -AsSecureString -Prompt 'ReferencePassword') {
				$ReferencePassword = $result
			} else {
				return
			}
		}
	}

	process {
		if ($DifferencePassword -and $_) {
			throw $(Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'AmbiguousParameterSet')
		}
		if (-not $DifferencePassword -and -not $_) {
			if ($result = Read-Host -AsSecureString -Prompt 'DifferencePassword') {
				$DifferencePassword = $result
			} else {
				return
			}
		}
		$processObject = $(if ($DifferencePassword) {$DifferencePassword} else {$_})
		if ($processObject -is [System.Security.SecureString]) {
			$secureStringPassword = $processObject
		} elseif ($processObject.Password -is [System.Security.SecureString]) {
			$secureStringPassword = $processObject.Password
		} elseif ($processObject.Credential.Password -is [System.Security.SecureString]) {
			$secureStringPassword = $processObject.Credential.Password
		} else {
			throw $((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'CannotConvertArgumentNoMessage') -f $null,'DifferencePassword',$null,$null,$null,$null,((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'CannotConvertArgument') -f $null,'DifferencePassword','System.Security.SecureString',$null,$null,$null,$_.ToString(),$null))
		}
		(Get-Password $ReferencePassword -AsPlainText -Force) -eq (Get-Password $processObject -AsPlainText -Force)
	}
}

function global:Read-Password {
	param (
		[switch]$Confirm
	)

	[System.Security.SecureString]$password
	[System.Security.SecureString]$confirmPassword
	if ($result = Read-Host -AsSecureString -Prompt 'Password') {
		$password = $result
	} else {
		return
	}
	if ($Confirm) {
		if ($result = (Read-Host -AsSecureString -Prompt 'Confirm password')) {
			$confirmPassword = $result
		} else {
			return
		}
		if (Compare-Password -ReferencePassword $password -DifferencePassword $confirmPassword) {
			$password
		} else {
			Write-Error 'The passwords you entered did not match.'
		}
	} else {
		$password
	}
}

#endregion
#region WMI Utility Functions

function global:ConvertTo-WmiFilter {
	param(
		[string]$PropertyName = $(throw ((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'ParameterArgumentValidationErrorNullNotAllowed') -f $null,'PropertyName')),
		[string[]]$FilterValues,
		[string[]]$LiteralFilterValues
	)
	
	$wmiFilterSet = @()
	if ($FilterValues.Count) {
		foreach ($item in $FilterValues) {
			if ($item -match '[\*\?]') {
				$wmiFilterSet += "$PropertyName LIKE '$($item.Replace('*','%').Replace('?','_'))'"
			} else {
				$wmiFilterSet += "$PropertyName = '$item'"
			}
		}
	}
	if ($LiteralFilterValues.Count) {
		foreach ($item in $LiteralFilterValues) {
			$wmiFilterSet += "$PropertyName = '$item'"
		}
	}
	[string]::Join(' OR ',$wmiFilterSet)
}

# Syntax:
#     Use-WmiNamespace [-Namespace] <string>
#     Use-WmiNamespace [-Reset]
function global:Use-WmiNamespace {
	param(
		[string]$Namespace,
		[switch]$Reset
	)

	if ($Namespace -and $Reset) {
		throw $(Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'AmbiguousParameterSet')
	}
	if (($MyInvocation.InvocationName -eq '.') -and ($MyInvocation.MyCommand.CommandType -eq [System.Management.Automation.CommandTypes]::Function)) {
		$scope = 'Local'
	} else {
		$scope = 1
	}
	if ($Reset) {
		Set-Variable -Scope $scope -Name PSWmiNamespace -Value $null -Force | Out-Null
	} else {
		if (-not $Namespace) {
			Write-Host -ForegroundColor White -Object ((Get-PSResourceString -BaseName ParameterBinderStrings -ResourceId PromptCaption) -f 'Use-WmiNamespace',$MyInvocation.PipelinePosition)
			Write-Host (Get-PSResourceString -BaseName ParameterBinderStrings -ResourceId PromptMessage)
			$result = Read-Host -Prompt "Namespace"
			if ($result) {
				$Namespace = $Namespace
			} else {
				return
			}
		}
		Set-Variable -Scope $scope -Name PSWmiNamespace -Value $Namespace -Force | Out-Null
	}
}

function global:New-WmiObject {
	param(
		[string]$Namespace = $PSWmiNamespace,
		[string]$Class = $(throw ((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'ParameterArgumentValidationErrorNullNotAllowed') -f $null,'Class')),
		[string[]]$ComputerName = @(),
		[System.Management.Automation.PSObject]$Credential = $null
	)

	if (-not $ComputerName) {
		$ComputerName = @('.')
	}
	$wmiClass = Get-WmiClass -Namespace $Namespace -Class $Class -ComputerName $ComputerName -Credential $Credential
	$instance = $wmiClass.PSBase.CreateInstance()
	$attempt = 1
	while (($instance.PSBase.Properties.Count -lt $instance.__PROPERTYCOUNT) -and ($attempt -le 5)) {
		$attempt++
		Start-Sleep -Milliseconds 200
	}
	$instance
}

function global:Refresh-WmiObject {
	param(
		[System.Management.ManagementObject]$WmiObject = $(throw ((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'ParameterArgumentValidationErrorNullNotAllowed') -f $null,'WmiObject')),
		[System.Management.Automation.PSObject]$Credential = $null
	)

	if ($Credential) {
		Get-WmiObject -Namespace $WmiObject.__NAMESPACE -Class $WmiObject.__CLASS -Filter "__RELPATH='$($WmiObject.__RELPATH.Replace('\','\\'))'" -ComputerName $WmiObject.__SERVER -Credential $Credential
	} else {
		Get-WmiObject -Namespace $WmiObject.__NAMESPACE -Class $WmiObject.__CLASS -Filter "__RELPATH='$($WmiObject.__RELPATH.Replace('\','\\'))'" -ComputerName $WmiObject.__SERVER
	}
}

function global:Get-WmiObjectFromManagementPath {
	param(
		[System.Management.Automation.PSObject]$ManagementPath,
		[System.Management.Automation.PSObject]$Credential = $null
	)

	if ($ManagementPath -isnot [System.Management.ManagementPath]) {
		$ManagementPath = [System.Management.ManagementPath]$ManagementPath
	}

	if ($Credential) {
		Get-WmiObject -Namespace $ManagementPath.NamespacePath -Class $ManagementPath.ClassName -Filter "__RELPATH='$($ManagementPath.RelativePath.Replace('\','\\'))'" -ComputerName $ManagementPath.Server -Credential $Credential
	} else {
		Get-WmiObject -Namespace $ManagementPath.NamespacePath -Class $ManagementPath.ClassName -Filter "__RELPATH='$($ManagementPath.RelativePath.Replace('\','\\'))'" -ComputerName $ManagementPath.Server
	}
}

function global:Get-WmiClass {
	param(
		[string]$Namespace = $null,
		[string]$Class = $(throw ((Get-PSResourceString -BaseName 'ParameterBinderStrings' -ResourceId 'ParameterArgumentValidationErrorNullNotAllowed') -f $null,'Class')),
		[string[]]$ComputerName = @(),
		[Switch]$IncludeDerivedClasses,
		[System.Management.Automation.PSObject]$Credential = $null
	)

	if (-not $ComputerName) {
		$ComputerName = @('.')
	}
	$filter = "__this isa '$Class'"
	if (-not $IncludeDerivedClasses) {
		$filter += " AND __CLASS='$Class'"
	}
	$defaultDisplayPropertySet = New-Object System.Management.Automation.PSPropertySet('DefaultDisplayPropertySet',[string[]]@('Name','Type','PropertyCount','Server','Namespace','Path'))
	$PSStandardMembers = [System.Management.Automation.PSMemberInfo[]]@($defaultDisplayPropertySet)
	$processScript = {
		if ($host.Name -eq 'PowerGUIHost') {
			$_.PSObject.TypeNames.Remove($_.PSObject.TypeNames[0]) | Out-Null
			if (($_.__NAMESPACE -eq $root) -and ($_.__CLASS -eq '__NAMESPACE')) {
				$_.PSObject.TypeNames.Insert(0,"$($_.PSObject.TypeNames[0])#Root")
			} elseif ($_.__GENUS -eq 2) {
				$_.PSObject.TypeNames.Insert(0,"$($_.PSObject.TypeNames[0])#Namespace")
			} elseif ($_.__GENUS -eq 1) {
				$_.PSObject.TypeNames.Insert(0,"$($_.PSObject.TypeNames[0])#Class")
			}
		}
		for ($i=0; $i -lt $_.PSObject.TypeNames.Count; $i++) {
			$_.PSObject.TypeNames[$i] += '#MemberOverrideExtension'
		}
		$_ | Add-Member -Force -Name Name -MemberType ScriptProperty -Value {if ($this.__CLASS -eq '__NAMESPACE') {$this.__NAMESPACE} else {$this.__CLASS}}
		for ($i=0; $i -lt $_.PSObject.TypeNames.Count; $i++) {
			$_.PSObject.TypeNames[$i] = $_.PSObject.TypeNames[$i] -replace '#MemberOverrideExtension$',''
		}
		$_ `
			| Add-Member -Force -Name Type -MemberType ScriptProperty -Value {if ($this.__GENUS -eq 1) {'Class'} elseif ($this.__GENUS -eq 2 ) {'Namespace'}} -PassThru `
			| Add-Member -Force -Name PropertyCount -MemberType AliasProperty -Value __PROPERTY_COUNT -PassThru `
			| Add-Member -Force -Name Server -MemberType AliasProperty -Value __SERVER -PassThru `
			| Add-Member -Force -Name Namespace -MemberType AliasProperty -Value __NAMESPACE -PassThru `
			| Add-Member -Force -Name Path -MemberType AliasProperty -Value __PATH -PassThru `
			| Add-Member -Force -Name PSStandardMembers -MemberType MemberSet -Value $PSStandardMembers -PassThru
	}
	if ($Credential) {
		Get-WmiObject -Namespace $Namespace -Class meta_class -Filter $filter -ComputerName $ComputerName -Credential $Credential | ForEach-Object $processScript
	} else {
		Get-WmiObject -Namespace $Namespace -Class meta_class -Filter $filter -ComputerName $ComputerName | ForEach-Object $processScript
	}
}

function global:Get-WmiRoot {
	param(
		[string[]]$ComputerName = @(),
		[System.Management.Automation.PSObject]$Credential = $null
	)

	Get-WmiClass -Namespace root -Class __NAMESPACE -ComputerName $ComputerName -Credential $Credential
}

#endregion

$cancelled = $false
$password = $null
if ($PasswordProtect) {
	$securePassword = Read-Host -AsSecureString -Prompt 'Enter the password for the new share(s).'
	if (-not $securePassword) {
		$cancelled = $true
	} else {
		$password = $securePassword | Get-Password -AsPlainText -Force
	}
}
if (-not $cancelled) {
	foreach ($item in @($ComputerName)) {
		$win32ShareClass = Get-WmiClass -Namespace root\cimv2 -Class Win32_Share -ComputerName $item
		$win32ShareClass.Create($FolderPath, $ShareName, 0, $SimultaneousUserLimit, $Description, $password, $null)
	}
}
}


 func_Shares | where { $_.Name -eq 'CC'} | action -ComputerName 'PC0674' -FolderPath 'd:\Man' -ShareName 'Testing' -Description 'For test only' 
#endregion ****************************** Execution completed - TreeNode: Shares ******************************
