﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFXIVMonReborn.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SapphireServer/Sapphire")]
        public string Repo {
            get {
                return ((string)(this["Repo"]));
            }
            set {
                this["Repo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:/Program Files (x86)/SquareEnix/FINAL FANTASY XIV - A Realm Reborn/game/sqpack")]
        public string GamePath {
            get {
                return ((string)(this["GamePath"]));
            }
            set {
                this["GamePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 198, 95")]
        public global::System.Drawing.Color ColorServerSet0 {
            get {
                return ((global::System.Drawing.Color)(this["ColorServerSet0"]));
            }
            set {
                this["ColorServerSet0"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("253, 218, 153")]
        public global::System.Drawing.Color ColorServerSet1 {
            get {
                return ((global::System.Drawing.Color)(this["ColorServerSet1"]));
            }
            set {
                this["ColorServerSet1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("140, 226, 255")]
        public global::System.Drawing.Color ColorClientSet0 {
            get {
                return ((global::System.Drawing.Color)(this["ColorClientSet0"]));
            }
            set {
                this["ColorClientSet0"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("183, 227, 255")]
        public global::System.Drawing.Color ColorClientSet1 {
            get {
                return ((global::System.Drawing.Color)(this["ColorClientSet1"]));
            }
            set {
                this["ColorClientSet1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DontUsePacketTimestamp {
            get {
                return ((bool)(this["DontUsePacketTimestamp"]));
            }
            set {
                this["DontUsePacketTimestamp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StripHeaderActors {
            get {
                return ((bool)(this["StripHeaderActors"]));
            }
            set {
                this["StripHeaderActors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceRealtimePriority {
            get {
                return ((bool)(this["ForceRealtimePriority"]));
            }
            set {
                this["ForceRealtimePriority"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int NetworkMonitorType {
            get {
                return ((int)(this["NetworkMonitorType"]));
            }
            set {
                this["NetworkMonitorType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LoadEXD {
            get {
                return ((bool)(this["LoadEXD"]));
            }
            set {
                this["LoadEXD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableFsWatcher {
            get {
                return ((bool)(this["EnableFsWatcher"]));
            }
            set {
                this["EnableFsWatcher"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideHexBoxActorId {
            get {
                return ((bool)(this["HideHexBoxActorId"]));
            }
            set {
                this["HideHexBoxActorId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StickPacketViewBottom {
            get {
                return ((bool)(this["StickPacketViewBottom"]));
            }
            set {
                this["StickPacketViewBottom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OodleEnforced {
            get {
                return ((bool)(this["OodleEnforced"]));
            }
            set {
                this["OodleEnforced"] = value;
            }
        }
    }
}
