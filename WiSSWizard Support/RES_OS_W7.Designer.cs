﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Actemium.WiSSWizard.Support {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RES_OS_W7 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RES_OS_W7() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Actemium.WiSSWizard.Support.RES_OS_W7", typeof(RES_OS_W7).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static byte[] Add_IIS7WebSite {
            get {
                object obj = ResourceManager.GetObject("Add_IIS7WebSite", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FullPath.
        /// </summary>
        internal static string EMOFullPathAddress {
            get {
                return ResourceManager.GetString("EMOFullPathAddress", resourceCulture);
            }
        }
        
        internal static byte[] Get_IIS7AllSiteStatus {
            get {
                object obj = ResourceManager.GetObject("Get_IIS7AllSiteStatus", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] getAllCurrentFirewallExceptions_Win7 {
            get {
                object obj = ResourceManager.GetObject("getAllCurrentFirewallExceptions_Win7", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UserAuthentication.
        /// </summary>
        internal static string RemoteDesktopEnableMoreSecureRegKey {
            get {
                return ResourceManager.GetString("RemoteDesktopEnableMoreSecureRegKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp.
        /// </summary>
        internal static string RemoteDesktopEnableMoreSecureRegPath {
            get {
                return ResourceManager.GetString("RemoteDesktopEnableMoreSecureRegPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ShutdownReasonUI.
        /// </summary>
        internal static string SDEVTRegKeyOnShutdownReasonUI {
            get {
                return ResourceManager.GetString("SDEVTRegKeyOnShutdownReasonUI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ShutdownReasonON.
        /// </summary>
        internal static string SDEVTRegKeyShutdownReason {
            get {
                return ResourceManager.GetString("SDEVTRegKeyShutdownReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HKLM:\SOFTWARE\Policies\Microsoft\Windows NT\Reliability.
        /// </summary>
        internal static string SDEVTRegPath {
            get {
                return ResourceManager.GetString("SDEVTRegPath", resourceCulture);
            }
        }
    }
}
