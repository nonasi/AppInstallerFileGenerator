﻿#pragma checksum "C:\Users\t-kedaig\OneDrive - Microsoft\AppInstaller XML Generator\AppInstaller XML Generator\AppInstallerFileGenerator\Samples\XamlNavigation\shared\CommandBarPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75A0E2E72AB562FB0A33B0EDF8B285A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppInstallerFileGenerator.Views
{
    partial class CommandBarPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\CommandBarPage.xaml line 41
                {
                    this.topbar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 2: // Views\CommandBarPage.xaml line 60
                {
                    this.pageTitleContainer = (global::AppInstallerFileGenerator.Controls.PageHeader)(target);
                }
                break;
            case 3: // Views\CommandBarPage.xaml line 66
                {
                    this.ContentContainer = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\CommandBarPage.xaml line 70
                {
                    this.bottombar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 5: // Views\CommandBarPage.xaml line 62
                {
                    this.AltHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\CommandBarPage.xaml line 54
                {
                    this.HeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

