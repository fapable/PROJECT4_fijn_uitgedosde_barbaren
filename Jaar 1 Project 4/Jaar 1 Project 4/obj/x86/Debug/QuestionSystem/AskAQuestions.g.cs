﻿#pragma checksum "C:\Users\Ino\Documents\GitHub\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\QuestionSystem\AskAQuestions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E73238A9B934AE2D3F773B1A80BE660B"
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
    partial class Questions : 
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
                    this.askquestions = (global::Windows.UI.Xaml.Controls.Grid)(target);
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
                    #line 18 "..\..\..\QuestionSystem\AskAQuestions.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.BackButtonClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.SendQuestion = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\QuestionSystem\AskAQuestions.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SendQuestion).Click += this.Send_message;
                    #line default
                }
                break;
            case 5:
                {
                    this.E_mail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.Naam = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.Vraag = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.Opleiding = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 23 "..\..\..\QuestionSystem\AskAQuestions.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Opleiding).SelectionChanged += this.Opleiding_SelectionChanged;
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

