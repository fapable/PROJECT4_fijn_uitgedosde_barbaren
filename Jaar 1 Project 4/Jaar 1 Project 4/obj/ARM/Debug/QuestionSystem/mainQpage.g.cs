﻿#pragma checksum "C:\Users\ramon\Documents\GitHub\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\QuestionSystem\mainQpage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A0B444989851491F440568BA3D78D49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jaar_1_Project_4.QuestionSystem
{
    partial class mainQpage : 
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
                    this.QuestionMenu = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.AskAQuestionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\QuestionSystem\mainQpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AskAQuestionButton).Click += this.AskAQuestion;
                    #line default
                }
                break;
            case 4:
                {
                    this.viewQuestionsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\QuestionSystem\mainQpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.viewQuestionsButton).Click += this.ToQandAButton;
                    #line default
                }
                break;
            case 5:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\QuestionSystem\mainQpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButtonClick;
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

