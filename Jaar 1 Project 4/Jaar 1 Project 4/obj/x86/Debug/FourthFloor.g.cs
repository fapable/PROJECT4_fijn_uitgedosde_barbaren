﻿#pragma checksum "D:\VS\Projects\C#\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\FourthFloor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8FA12E1D670186F35D475E1ED30C1209"
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
    partial class FourthFloor : 
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
                    this.fourth_floor = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.fourthFlourBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\FourthFloor.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.fourthFlourBackButton).Click += this.fourthFlourBackButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

