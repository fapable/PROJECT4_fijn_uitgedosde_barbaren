﻿#pragma checksum "C:\Users\ramon\Desktop\New folder\Jaar 1 Project 4\Jaar 1 Project 4\LoginSystem\CreateAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3BD147FD45FED12DBD0A7A4C203A492D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jaar_1_Project_4
{
    partial class CreateAccount : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.create_accoutn = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\LoginSystem\CreateAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.back_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.usernameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.passwordText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.ussernameTypeBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.createAccountButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\LoginSystem\CreateAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.createAccountButton).Click += this.createAccountButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.passwordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

