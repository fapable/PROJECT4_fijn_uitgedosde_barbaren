﻿#pragma checksum "B:\School\Hogeschool\Homework\Projecten\Project 4\githubClone\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\StudentLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E593D02ABCC89163A80E3B6182AA1645"
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
    partial class StudentLogin : 
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
                    this.studentLoginMainText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.usernameLoginText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.passwordLoginText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.studentLoginBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\StudentLogin.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.studentLoginBackButton).Click += this.studentLoginBackButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.UsernameTypeBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 25 "..\..\..\StudentLogin.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.UsernameTypeBox).KeyDown += this.isEntered;
                    #line default
                }
                break;
            case 6:
                {
                    this.passwordTypeBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 27 "..\..\..\StudentLogin.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.passwordTypeBox).KeyDown += this.passwordTypeBox_KeyDown;
                    #line default
                }
                break;
            case 7:
                {
                    this.logInButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\StudentLogin.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.logInButton).Click += this.createButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\StudentLogin.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
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

