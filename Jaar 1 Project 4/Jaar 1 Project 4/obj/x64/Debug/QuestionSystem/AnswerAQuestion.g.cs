﻿#pragma checksum "B:\School\Developing\Github projects\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\QuestionSystem\AnswerAQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F073ACF92CE0B7FA306635F18A741BF"
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
    partial class Answer : 
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
                    this.answerquestions = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 11 "..\..\..\QuestionSystem\AnswerAQuestion.xaml"
                    #line default
                }
                break;
            case 3:
                {
                    this.sendButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\QuestionSystem\AnswerAQuestion.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.sendButton).Click += this.Send_message;
                    #line default
                }
                break;
            case 4:
                {
                    this.answerBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.vraagBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\QuestionSystem\AnswerAQuestion.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.BackButtonClick;
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

