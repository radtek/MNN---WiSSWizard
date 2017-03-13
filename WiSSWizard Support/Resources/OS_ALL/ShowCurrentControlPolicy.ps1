
$domain = [ADSI]"WinNT://$env:userdomain" 

$AuditAccountLogonEvent = @{Name="Audit account logon events";Expression={"1"}} 
$AuditAccountManagement = @{Name="Audit account management";Expression={"2"}} 
$AuditDirSerAccess = @{Name="Audit directory service access";Expression={"2"}} 
$AuditLogonEvent = @{Name="Audit logon event";Expression={"3"}} 
$AuditObjectAccess = @{Name="Audit object access";Expression={"2"}} 
$AuditPolicyChang = @{Name="Audit policy change";Expression={"3"}} 
$AuditPrevilegeUse = @{Name="Audit previlege use";Expression={"0"}} 
$AuditProcessTracking = @{Name="Audit process tracking";Expression={"0"}} 
$AuditSystemEvent = @{Name="Audit system events";Expression={"3"}} 
$domain | Select-Object $AuditAccountLogonEvent,$AuditAccountManagement,$AuditDirSerAccess,$AuditLogonEvent,$AuditObjectAccess,$AuditPolicyChang,$AuditPrevilegeUse,$AuditProcessTracking,$AuditSystemEvent
