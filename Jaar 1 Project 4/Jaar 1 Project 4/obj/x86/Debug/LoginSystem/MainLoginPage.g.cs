﻿#pragma checksum "C:\Users\ramon\Documents\GitHub\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\LoginSystem\MainLoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEC8C7C0BB5854CB39B24D02D80E5E2D"
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
    partial class MainLoginPage : 
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
                    this.main_page = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.studentInlogButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\LoginSystem\MainLoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.studentInlogButton).Click += this.studentLoginClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.teacherInlogButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\LoginSystem\MainLoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.teacherInlogButton).Click += this.teacherLoginClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.exitInlogButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\LoginSystem\MainLoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.exitInlogButton).Click += this.ExitClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.mainInlogText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

