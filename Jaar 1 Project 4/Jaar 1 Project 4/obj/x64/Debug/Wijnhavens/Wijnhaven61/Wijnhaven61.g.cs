﻿#pragma checksum "B:\School\Developing\Github projects\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\Wijnhavens\Wijnhaven61\Wijnhaven61.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3BAECA82455FFB5E1F7F85B771C97ED1"
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
    partial class Wijnhaven61 : 
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
                    this.wijnhaven_61 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.wijnhaven61EducationButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\..\Wijnhavens\Wijnhaven61\Wijnhaven61.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.wijnhaven61EducationButton).Click += this.EducationButtonClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\..\Wijnhavens\Wijnhaven61\Wijnhaven61.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.BackButtonClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.infoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
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

