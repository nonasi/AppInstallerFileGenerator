﻿#pragma checksum "C:\Users\t-kedaig\OneDrive - Microsoft\AppInstaller XML Generator\AppInstaller XML Generator\Windows Samples\Samples\XamlNavigation\cs\Views\OptionalPackagesView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C0909403879F36F29EDB5BB1C2ABFEAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavigationMenu.Views
{
    partial class OptionalPackagesView : 
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
            case 1: // Views\OptionalPackagesView.xaml line 17
                {
                    this.TitlePage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2: // Views\OptionalPackagesView.xaml line 45
                {
                    this.File_Path_Text_Box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.File_Path_Text_Box).TextChanged += this.File_Path_Text_Box_TextChanged;
                }
                break;
            case 3: // Views\OptionalPackagesView.xaml line 31
                {
                    this.Package_Type_Combo_Box = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Package_Type_Combo_Box).SelectionChanged += this.Package_Type_Combo_Box_SelectionChanged;
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

