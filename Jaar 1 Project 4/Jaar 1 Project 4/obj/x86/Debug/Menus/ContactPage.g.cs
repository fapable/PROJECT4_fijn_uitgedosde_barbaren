﻿#pragma checksum "C:\Users\ramon\Documents\GitHub\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\Menus\ContactPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "286E1330095BC661D1388FF85CCC76C1"
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
    partial class ContactPage : 
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
                    this.contacttitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Menus\ContactPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.BackButtonclick;
                    #line default
                }
                break;
            case 3:
                {
                    this.Studychoice = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Menus\ContactPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Studychoice).Click += this.StudyChoiceClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.Education_question = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\Menus\ContactPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Education_question).Click += this.StudyChoiceClick;
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

