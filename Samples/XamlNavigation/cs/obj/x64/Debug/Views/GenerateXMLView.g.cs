﻿#pragma checksum "C:\Users\t-kedaig\OneDrive - Microsoft\AppInstaller XML Generator\AppInstaller XML Generator\AppInstallerFileGenerator\Samples\XamlNavigation\cs\Views\GenerateXMLView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF42DF147A83866244DE191F9ED121A9"
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
    partial class GenerateXMLView : 
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
            case 1: // Views\GenerateXMLView.xaml line 55
                {
                    this.Next_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 2: // Views\GenerateXMLView.xaml line 65
                {
                    this.Back_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back_Button).Click += this.Back_Button_Click;
                }
                break;
            case 3: // Views\GenerateXMLView.xaml line 21
                {
                    this.TitlePage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\GenerateXMLView.xaml line 30
                {
                    this.Generate_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Generate_Button).Click += this.Generate_File_Button_Click;
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

