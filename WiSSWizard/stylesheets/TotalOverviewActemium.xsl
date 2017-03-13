<?xml version="1.0" encoding="ISO-8859-1"?>
<!-- Edited by XMLSpy® -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
    <head>
      <style type="text/css">
        body {
        font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif;
        margin:0px 0px 0px 20px;
        }
        h2 {font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif
        }
        h4 {
        font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif;
        margin:10px 0px 0px 0px;

        }

      </style>
    
    </head>
  <body>

    <h2>Actemium WiSSWizard - Windows Security Setup</h2>

    <table border="0">
      <td WIDTH="300"> </td>
      <tr>
        <td>
          Date:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetDefaultInformation/ConfigDateTime"/>
        </td>
      </tr>
      <tr>
        <td>
          Firstname:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetDefaultInformation/ApplicationUserName"/>
        </td>
      </tr>
      <tr>
        <td>
          Lastname:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetDefaultInformation/ApplicationFamilyName"/>
        </td>
      </tr>
      <tr>
        <td>
          Operation System:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetDefaultInformation/Operatingsystem"/>
        </td>
      </tr>
      <tr>
        <td>
          Computer name:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetDefaultInformation/ComputerName"/>
        </td>
      </tr>

      <xsl:if test="ConfigClass/ConfSetDefaultInformation/SecurityConfiguration = 'true'">
        <tr>
          <td>
            Type configuration:
          </td>
          <td>
            Security
          </td>
        </tr>
      </xsl:if>
      <xsl:if test="ConfigClass/ConfSetDefaultInformation/LockDownConfiguration = 'true'">
        <tr>
          <td>
            Type configuration:
          </td>
          <td>
            LockDown
          </td>
        </tr>
      </xsl:if>
      <xsl:if test="ConfigClass/ConfSetDefaultInformation/AdvancedConfiguration = 'true'">
        <tr>
          <td>
            Type configuration:
          </td>
          <td>
            All Settings
          </td>
        </tr>
      </xsl:if>
      <xsl:if test="ConfigClass/ConfSetDefaultInformation/LoadtemplateConfiguration = 'true'">
        <tr>
          <td>
            Type configuration:
          </td>
          <td>
            Load template
          </td>
        </tr>
      </xsl:if>
    </table>

    <!-- Software overview -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <td WIDTH="300">
        <h4>Software installed</h4>
      </td>
<!--
      <tr>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/PcAnywhere = 'true'">
          <tr>
            <td>
              Pc AnyWhere:
            </td>
            <td>
              Installed
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/PcAnywhere = 'false'">
          <tr>
            <td>
              Pc AnyWhere:
            </td>
            <td>
              Not installed
            </td>
          </tr>
        </xsl:if>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/BlockKeys = 'true'">
          <tr>
            <td>
              BlockKeys
            </td>
            <td>
              Installed
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/BlockKeys = 'false'">
          <tr>
            <td>
              BlockKeys
            </td>
            <td>
              Not installed
            </td>
          </tr>
        </xsl:if>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/SQLServer = 'true'">
          <tr>
            <td>
              Microsoft SQL server:
            </td>
            <td>
              Installed
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/SQLServer = 'false'">
          <tr>
            <td>
              Microsoft SQL server:
            </td>
            <td>
              Not installed
            </td>
          </tr>
        </xsl:if>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/IIS = 'true'">
          <tr>
            <td>
              Internet Information Services:
            </td>
            <td>
              Installed
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/IIS = 'false'">
          <tr>
            <td>
              Internet Information Services:
            </td>
            <td>
              Not installed
            </td>
          </tr>
        </xsl:if>
      </tr>-->
      <tr>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/MBSA = 'true'">
          <tr>
            <td>
              Microsoft Baseline Security Analyzer:
            </td>
            <td>
              Installed
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfInstalledSoftware/MBSA = 'false'">
          <tr>
            <td>
              Microsoft Baseline Security Analyzer:
            </td>
            <td>
              Not Installed
            </td>
          </tr>
        </xsl:if>
      </tr>

    </table>

    <!-- Password policy -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Password Policy</h4>
        </td>
      </tr>
      <tr>
        <td>
          Maximum password age:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetPasswordPolicy/MaximumPasswordAge"/>
        </td>
        <td>days</td>
      </tr>
      <tr>
        <td>
          Minimum password age:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetPasswordPolicy/MinimumPasswordAge"/>
        </td>
        <td>date</td>
      </tr>
      <tr>
        <td>
          Minimum password length:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetPasswordPolicy/MinimumPasswordLength"/>
        </td>
        <td>characters</td>
      </tr>
      <tr>
        <td>
          Number of passwords remembered:
        </td>
        <td>
          <xsl:value-of select="ConfigClass/ConfSetPasswordPolicy/PasswordHistorySize"/>
        </td>
        <td>password(s)</td>
      </tr>
      <tr>
        <td>
          Meet complexity requirements:
        </td>
        <td></td>
        <td>
          <xsl:if test="ConfigClass/ConfSetPasswordPolicy/PasswordComplexity = '0'">Disabled</xsl:if>
          <xsl:if test="ConfigClass/ConfSetPasswordPolicy/PasswordComplexity = '1'">Enabled</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Save with reversible encryption:
        </td>
        <td></td>
        <td>
          <xsl:if test="ConfigClass/ConfSetPasswordPolicy/ClearTextPassword = '0'">Disabled</xsl:if>
          <xsl:if test="ConfigClass/ConfSetPasswordPolicy/ClearTextPassword = '1'">Enabled</xsl:if>
        </td>
      </tr>

    </table>

    <!-- Audit policy -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Controle Policy</h4>
        </td>
      </tr>
      <tr>
        <td>
          Notification events:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditLogonEvents = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditLogonEvents = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditLogonEvents = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditLogonEvents = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Account Login Information:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountLogon = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountLogon = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountLogon = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountLogon = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Account management:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountManage = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountManage = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountManage = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditAccountManage = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Active Directory-access:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditDSAccess = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditDSAccess = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditDSAccess = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditDSAccess = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Policy Changes:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPolicyChange = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPolicyChange = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPolicyChange = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPolicyChange = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Use of powers:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPrivilegeUse = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPrivilegeUse = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPrivilegeUse = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditPrivilegeUse = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Object-access:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditObjectAccess = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditObjectAccess = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditObjectAccess = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditObjectAccess = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Process Detection:

        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditProcessTracking = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditProcessTracking = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditProcessTracking = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditProcessTracking = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          System Events:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditSystemEvents = '0'">Not check</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditSystemEvents = '1'">Successful</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditSystemEvents = '2'">Failed</xsl:if>
          <xsl:if test="ConfigClass/ConfSetAuditPolicy/AuditSystemEvents = '3'">Successful, Failed</xsl:if>
        </td>
      </tr>
    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetAuditPolicy/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>Comment:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetAuditPolicy/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- new usergroups -->
    <table>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetWindowsUsergroup/NewUserGroups/UserGroup != ''">
          <tr>
            <td HEIGHT ="25"></td>
          </tr>
          <br />
          <tr>
            <td WIDTH="300">
              <h4>Chosen settings that different from the default configuration</h4>
            </td>

          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsUsergroup/NewUserGroups/UserGroup">
            <tr>
              <td HEIGHT ="15"></td>
            </tr>
            <tr>
              <td>
                <b>Name:</b>
              </td>
            </tr>
            <tr>
              <td>
                <xsl:value-of select="Name"/>
              </td>
            </tr>

            <tr>
              <td>
                <b>Description:</b>
              </td>
            </tr>
            <tr>
              <td>
                <xsl:value-of select="Description"/>
              </td>
            </tr>
            <tr>
              <td>
              </td>
              <td>
              </td>
            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
    </table>

    <!-- deleted usergroups -->
    <table>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetWindowsUsergroup/DeletedUserGroups/UserGroup != ''">
          <tr>
            <td HEIGHT ="25"></td>
          </tr>
          <br />
          <tr>
            <td WIDTH="300">
              <h4>Chosen settings that different from the default configuration</h4>
            </td>

          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsUsergroup/DeletedUserGroups/UserGroup">
            <tr>
              <td HEIGHT ="15"></td>
            </tr>
            <tr>
              <td>
                <b>Name:</b>
              </td>
            </tr>
            <tr>
              <td>
                <xsl:value-of select="Name"/>
              </td>
            </tr>

            <tr>
              <td>
                <b>Description:</b>
              </td>
            </tr>
            <tr>
              <td>
                <xsl:value-of select="Description"/>
              </td>
            </tr>
            <tr>
              <td>
              </td>
              <td>
              </td>
            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
    </table>

    <!-- new users -->
    <table>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetWindowsUsers/NewUsers != ''">
          <tr>
            <td HEIGHT ="25"></td>
          </tr>
          <br />
          <tr>
            <td WIDTH="300">
              <H4>Chosen settings that different from the default configuration</H4>
            </td>

          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsUsers/NewUsers/NewUser">
            <tr>
              <td HEIGHT ="15"></td>
            </tr>
            <tr>
              <td>
                <b>
                  <xsl:value-of select="Name"/>
                </b>
              </td>
              <td>
              </td>
            </tr>

            <tr>
              <td>
                Fullname:
              </td>
              <td>
                <xsl:value-of select="Fullname"/>
              </td>
            </tr>

            <tr>
              <td>
                Description:
              </td>
              <td>
                <xsl:value-of select="Description"/>
              </td>
            </tr>

            <tr>
              <td>
                Group:
              </td>
              <td>
                <xsl:value-of select="UserGroup"/>
              </td>
            </tr>

            <tr>
              <td>
                Password is changed at the next login attempt:
              </td>
              <td>
                <xsl:value-of select="ChangePwNextLogon"/>
              </td>
            </tr>

            <tr>
              <td>
                Password can not be changed:
              </td>
              <td>
                <xsl:value-of select="PasswordCantBeChanged"/>
              </td>
            </tr>

            <tr>
              <td>
                Password never expires:
              </td>
              <td>
                <xsl:value-of select="PasswordNeverExpires"/>
              </td>
            </tr>

            <tr>
              <td>
                Account is disabled:
              </td>
              <td>
                <xsl:value-of select="AccountDisabled"/>
              </td>
            </tr>

            <tr>
              <td>
                Password:
              </td>
              <td>
                <xsl:value-of select="Password"/>
              </td>
            </tr>

            <tr>
              <td>
              </td>
              <td>
              </td>
            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
    </table>

    <!-- modyfied users -->
    <table>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetWindowsUsers/ModifiedUsers != ''">
          <tr>
            <td HEIGHT ="25"></td>
          </tr>
          <br />
          <tr>
            <td WIDTH="300">
              <H4>These users will be modified</H4>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsUsers/ModifiedUsers/ModfiedUser">
            <tr>
              <td HEIGHT ="15"></td>
            </tr>
            <tr>
              <td>
                <b>
                  <xsl:value-of select="Name"/>
                </b>
              </td>
              <td>
              </td>
            </tr>

            <tr>
              <td>
                Fullname:
              </td>
              <td>
                <xsl:value-of select="Fullname"/>
              </td>
            </tr>

            <tr>
              <td>
                Description:
              </td>
              <td>
                <xsl:value-of select="Description"/>
              </td>
            </tr>

            <tr>
              <td>
                Password is changed at the next login attempt:
              </td>
              <td>
                <xsl:value-of select="ChangePwNextLogon"/>
              </td>
            </tr>

            <tr>
              <td>
                Password can not be changed:
              </td>
              <td>
                <xsl:value-of select="PasswordCantBeChanged"/>
              </td>
            </tr>

            <tr>
              <td>
                Password never expires:
              </td>
              <td>
                <xsl:value-of select="PasswordNeverExpires"/>
              </td>
            </tr>

            <tr>
              <td>
                Account is disabled:
              </td>
              <td>
                <xsl:value-of select="AccountDisabled"/>
              </td>
            </tr>

            <tr>
              <td>
                Password:
              </td>
              <xsl:choose>
                <xsl:when test="Password = '-1'">
                  <td>
                    Password does not change
                  </td>
                </xsl:when>
                <xsl:otherwise>
                  <td>
                    <xsl:value-of select="Password"/>
                  </td>
                </xsl:otherwise>
              </xsl:choose>
            </tr>
            <tr>
              <td>
              </td>
              <td>
              </td>
            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
    </table>

    <!-- deleted users -->
    <table>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetWindowsUsers/DeletedUsers != ''">
          <tr>
            <td HEIGHT ="25"></td>
          </tr>
          <tr>
            <td WIDTH="300">
              <H4>The following users are removed</H4>

            </td>
          </tr>


          <xsl:for-each select="ConfigClass/ConfSetWindowsUsers/DeletedUsers/DeletedUser">
            <tr>
              <td >
                <b>
                  <xsl:value-of select="Name"/>
                </b>
              </td>
              <td>
              </td>
            </tr>

          </xsl:for-each>

          <tr>
            <td>
            </td>
            <td>
            </td>
          </tr>
        </xsl:when>
      </xsl:choose>
    </table>

    <!-- AutoPlay -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Autoplay setting</h4>
        </td>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfSetAutoPlaySettings/AutoPlayOff = 'true'">
          <td>
            AutoPlay disabled for:
          </td>
          <td>
            <xsl:if test="ConfigClass/ConfSetAutoPlaySettings/AutoPlaySetting = '1'">All drives</xsl:if>
            <xsl:if test="ConfigClass/ConfSetAutoPlaySettings/AutoPlaySetting = '0'">CD-ROM and removable media drives</xsl:if>

          </td>
        </xsl:if>

        <xsl:if test="ConfigClass/ConfSetAutoPlaySettings/AutoPlayOff = 'false'">
          <td>
            AutoPlay enabled
          </td>
          <td>

          </td>
        </xsl:if>

      </tr>
    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetAutoPlaySettings/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>Comment:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetAutoPlaySettings/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- Explorer Settings -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">

          <h4>Windows explorer folder options</h4>
        </td>
      </tr>
      <tr>
        <td>
          Automatically search for network folders and printers:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/AutomaticallySearchNetworkFoldersAndPrinters = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/AutomaticallySearchNetworkFoldersAndPrinters = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          display the contents of system folders:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/DisplayContentOfSystemFolder = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/DisplayContentOfSystemFolder = 'false'">
            False
          </xsl:if>

        </td>
      </tr>
      <tr>
        <td>
          Display the full path in the Address bar:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/DisplayFullPathInAddressBar = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/DisplayFullPathInAddressBar = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Show hidden files and folders:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/ShowHiddenFolders = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/ShowHiddenFolders = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Hide extensions for known file types:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/HideExtensions = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/HideExtensions = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Hide protected operating system files:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/HideProtectedOSFiles = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/HideProtectedOSFiles = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          The view settings for each folder:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/RememberEachFoldersViewSetting = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/RememberEachFoldersViewSetting = 'false'">
            False
          </xsl:if>
        </td>
      </tr>
      <tr>
        <td>
          Show encrypted or compressed NTFS files in color:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/ShowNTFSFilesInColor = 'true'">
            True
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetwindowsExplorerSettings/ShowNTFSFilesInColor = 'false'">
            False
          </xsl:if>
        </td>
      </tr>

    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetwindowsExplorerSettings/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetwindowsExplorerSettings/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <u>
                  <xsl:value-of select="Setting"/>
                </u>
              </td>

            </tr>
            <tr>
              <td>
                Comment:
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- Log in Shutdown -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Log-in and shutdown setting</h4>
        </td>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfSetLoginShutdownSettings/AutologonInUse = 'true'">
          <td>
            Autologon enabled
          </td>
          <td>
            <tr>
              <td>
                Login name:
              </td>
              <td>
                <xsl:value-of select="ConfigClass/ConfSetLoginShutdownSettings/UsernameAutoLogon"/>
              </td>
            </tr>
            <tr>
              <td>
                password:
              </td>
              <td>
                <xsl:value-of select="ConfigClass/ConfSetLoginShutdownSettings/PasswordAutoLogon"/>
              </td>
            </tr>
          </td>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfSetLoginShutdownSettings/AutologonInUse = 'false'">
          <td>
            Autologin disabled
          </td>
          <td>

          </td>
        </xsl:if>

      </tr>
      <tr></tr>
      <tr>
        <td>
          <xsl:if test="ConfigClass/ConfSetLoginShutdownSettings/ShutDownEventTrackerInUse = 'true'">Shutdown event tracker enabled </xsl:if>
          <xsl:if test="ConfigClass/ConfSetLoginShutdownSettings/ShutDownEventTrackerInUse = 'false'">Shutdown event tracker disabled </xsl:if>
        </td>
      </tr>
    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetLoginShutdownSettings/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>comment:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetLoginShutdownSettings/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- Remote Desktop -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Remote desktop</h4>
        </td>
      </tr>

      <tr>
        <td>
          <xsl:if test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopDisabled = 'true'">
            Remotedesktop disabled
          </xsl:if>
          <xsl:if test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopEnabledForAllPCs = 'true'">
            <xsl:if test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopEnabledOnlyForPCsWithNLA = 'true'">
              Remotedesktop enabled for computers with "Remote Desktop" with Network Level Authentication. (Safer)

            </xsl:if>
            <xsl:if test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopEnabledOnlyForPCsWithNLA = 'false'">
              Remote Desktop enabled on computers running any version of "Remote Desktop"
               (less safe)
            </xsl:if>
          </xsl:if>
        </td>
      </tr>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopUsers != ''">
          <tr>
          </tr>
          <tr>
            <td>
              <i>
                <u>RemoteDesktopUsers: </u>
              </i>
            </td>
          </tr>

          <xsl:for-each select="ConfigClass/ConfSetRemotedesktop/RemoteDesktopUsers/RemoteDesktopUser">
            <tr>
              <td >
                <xsl:value-of select="Name"/>
              </td>

            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
      <xsl:choose>
        <xsl:when test="ConfigClass/ConfSetRemotedesktop/RemoteDesktopGroups != ''">
          <tr>
          </tr>
          <tr>
            <td>
              <i>
                <u>RemoteDesktopGroups: </u>
              </i>
            </td>
          </tr>

          <xsl:for-each select="ConfigClass/ConfSetRemotedesktop/RemoteDesktopGroups/RemoteDesktopGroup">
            <tr>
              <td >
                <xsl:value-of select="Name"/>
              </td>

            </tr>
          </xsl:for-each>
        </xsl:when>
      </xsl:choose>
    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetRemotedesktop/NoDefaultSettingsLog != ''">

        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>Comment:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetRemotedesktop/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- Windows Firewall -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="300">
          <h4>Windows Firewall</h4>
        </td>
      </tr>
      <tr>
        <td>
          Status Windows Firewall:
        </td>
        <td>
          <xsl:if test="ConfigClass/ConfSetWindowsFirewall/FireWallOn = 'true'">Enabled</xsl:if>
          <xsl:if test="ConfigClass/ConfSetWindowsFirewall/FireWallOn = 'false'">Disabled</xsl:if>
        </td>
      </tr>
    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetWindowsFirewall/AddFireWallExceptions != ''">
        <table>
          <tr>
            <td>
              <b>FireWall exceptions to be added:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsFirewall/AddFireWallExceptions/FireWallException">
            <tr>
              <td>
                <b>-</b>
                <xsl:value-of select="ExceptionName"/>
              </td>
            </tr>

          </xsl:for-each>
        </table>
      </xsl:when>
    </xsl:choose>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetWindowsFirewall/DeleteFireWallExceptions != ''">
        <table>
          <tr>
            <td>
              <b>FireWall exceptions to be deleted:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsFirewall/DeleteFireWallExceptions/FireWallException">
            <tr>
              <td>
                <b>-</b>
                <xsl:value-of select="ExceptionName"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </xsl:when>
    </xsl:choose>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetWindowsFirewall/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>Commnet:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetWindowsFirewall/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>

    <!-- MBSA -->
    <table>
      <tr>
        <td HEIGHT ="25"></td>
      </tr>
      <tr>
        <td WIDTH="140">
          <h4>MBSA Setting</h4>
        </td>
      </tr>
      <tr>
        <xsl:if test="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/RunMBSA = 'true'">
          <tr>
            <td>
              MBSA enabled
            </td>
          </tr>
          <tr>
            <td>
              <xsl:value-of select="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/PathMBSA"/>
            </td>
          </tr>
        </xsl:if>
        <xsl:if test="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/RunMBSA = 'false'">
          <td>
            MBSA disabled
          </td>
        </xsl:if>

      </tr>

    </table>
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/NoDefaultSettingsLog != ''">
        <table>
          <tr>
            <td>
              <b>Chosen settings that different from the default configuration:</b>
            </td>
          </tr>
        </table>
        <table>
          <tr>
            <td WIDTH="300">
              <b>Setting</b>
            </td>
            <td>
              <b>Comment:</b>
            </td>
          </tr>
          <xsl:for-each select="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/NoDefaultSettingsLog/NoDefaultSettingsLog">
            <tr>
              <td>
                <xsl:value-of select="Setting"/>
              </td>
              <td>
                <xsl:value-of select="Comment"/>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </xsl:when>
    </xsl:choose>
  
    <!--Fouten Overzicht-->
    <xsl:choose>
      <xsl:when test="ConfigClass/ErrorList != ''">
    <h2>Fouten Overzicht:</h2>

    <table>
      <tr>
        <td></td>

        <td WIDTH="300">
          <b>Configuratie step:</b>
        </td>

        <td>
          <b>Fault summary:</b>
        </td>
      </tr>
      <xsl:for-each select="ConfigClass/ErrorList/ConfigErrors">

        <tr>
          <td>
            <!-- <img src= "ConfigClass/@ErrorImageURL"/>-->
          </td>
          <td>
            
            <xsl:value-of select="ConfigError"/>
          </td>
          <td>
            <xsl:value-of select="ErrorMessage"/>
          </td>
        </tr>

      </xsl:for-each>
    </table>
    <table>
      <tr>
        <td>
          <b>The user has confirmed and read the errors,</b>
        </td>
        </tr>
      <tr>
        <td>
          <b>
            Comment:
          </b>
        </td>
      </tr>
      <tr>
        <td>
        <xsl:value-of select="ConfigClass/ErrorOverviewComment"/>
        </td>
      </tr>
    </table>
      </xsl:when>
    </xsl:choose>
    
    <!--MBSA Rapport-->
    <xsl:choose>
      <xsl:when test="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/MBSAlogs != ''">
        <h2>MBSA Report:</h2>
         <table>
               <xsl:for-each select="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/MBSAlogs/MBSAlogItem">
            <tr>
              <td>
                <xsl:value-of select="LogItem "/>
              </td>
            </tr>

          </xsl:for-each>
         </table>
         <table>
           <tr>
             <td>
               <b>The user has confirmed that report have been read,</b>
             </td>
           </tr>
           <tr>
             <td>
               <b>
                 Comment:
               </b>
             </td>
           </tr>
           <tr>
             <td>
               <xsl:value-of select="ConfigClass/ConfSetMicrosoftBaslineSecurityAnalyzer/MBSAoverviewComment"/>
             </td>
           </tr>
         

        </table>
      </xsl:when>
    </xsl:choose>
    
    <!--WhiteSpace-->
    <table>
    <tr>
      <td HEIGHT ="25"></td>
    </tr>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>