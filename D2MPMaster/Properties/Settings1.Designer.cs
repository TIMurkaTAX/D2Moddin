﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D2MPMaster.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d2moddin")]
        public string MongoDB {
            get {
                return ((string)(this["MongoDB"]));
            }
            set {
                this["MongoDB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AKIAIDO3KQPVQMEEFIUA")]
        public string AWSKey {
            get {
                return ((string)(this["AWSKey"]));
            }
            set {
                this["AWSKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("fjawqe3XkLZlm2LGd+acPDsERgmxZA9yDaD5mgsR")]
        public string AWSSecret {
            get {
                return ((string)(this["AWSSecret"]));
            }
            set {
                this["AWSSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d2mpclient")]
        public string Bucket {
            get {
                return ((string)(this["Bucket"]));
            }
            set {
                this["Bucket"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[{\"name\":\"d2fixups\",\"version\":\"0.2\",\"bundle\":\"serv_d2fixups.zip\"},{\"name\":\"metamo" +
            "d\",\"version\":\"0.3.4\",\"bundle\":\"metamod.zip\"},{\"name\":\"lobby\",\"version\":\"1.4\",\"bu" +
            "ndle\":\"lobby.zip\"},{\"name\":\"dst\",\"version\":\"0.1\",\"bundle\":\"dst.zip\"}]")]
        public string ServerAddons {
            get {
                return ((string)(this["ServerAddons"]));
            }
            set {
                this["ServerAddons"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://ddp2.d2modd.in/gdataapi/matchres")]
        public string PostURL {
            get {
                return ((string)(this["PostURL"]));
            }
            set {
                this["PostURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mongodb://appfog:E74y9KXNuUhE6F4pbFvC@capital.0.mongolayer.com:10048/d2moddin")]
        public string MongoURL {
            get {
                return ((string)(this["MongoURL"]));
            }
            set {
                this["MongoURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8080")]
        public int WebserverBind {
            get {
                return ((int)(this["WebserverBind"]));
            }
            set {
                this["WebserverBind"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mongodb://development:fcnbZAAHb5ajp57WGCWn@kahana.mongohq.com:10065/d2mpdev")]
        public string MongoDevURL {
            get {
                return ((string)(this["MongoDevURL"]));
            }
            set {
                this["MongoDevURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d2mpdev")]
        public string MongoDevDB {
            get {
                return ((string)(this["MongoDevDB"]));
            }
            set {
                this["MongoDevDB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ddp2.d2modd.in")]
        public string WebAddress {
            get {
                return ((string)(this["WebAddress"]));
            }
            set {
                this["WebAddress"] = value;
            }
        }
    }
}
