﻿#pragma checksum "D:\Project\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\LoginSystem\TeacherLogIn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7E7441DA304BFD2F4A302AF688BEB05"
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
    partial class TeacherLogIn : 
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
                    this.teacher_login = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTeacherText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.usernameLoginText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.passwordLoginText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.UsernameTypeBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.logInButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\LoginSystem\TeacherLogIn.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.logInButton).Click += this.logInButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.studentLoginBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\LoginSystem\TeacherLogIn.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.studentLoginBackButton).Click += this.studentLoginBackButton_Click;
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

