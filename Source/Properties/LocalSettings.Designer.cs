﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class LocalSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static LocalSettings defaultInstance = ((LocalSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LocalSettings())));
        
        public static LocalSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("local")]
        public string cassandraCluster {
            get {
                return ((string)(this["cassandraCluster"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=127.0.0.1;Database=inworldz;User ID=root;password=secret;Min Pool S" +
            "ize=5;")]
        public string coreConnStr {
            get {
                return ((string)(this["coreConnStr"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=127.0.0.1;Database=inworldz;User ID=root;password=secret;Min Pool Size" +
            "=5;")]
        public string encKeyConnStr {
            get {
                return ((string)(this["encKeyConnStr"]));
            }
        }
    }
}