﻿#pragma checksum "C:\Users\ramon\Desktop\New folder\Jaar 1 Project 4\Jaar 1 Project 4\Menus\WijnhavenLocations.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "72E104C8941FC1921B7280CB83083797"
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
    partial class WijnhavenLocations : 
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
                    this.wijnhaven_locations = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.wijnhavenLocationBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Menus\WijnhavenLocations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.wijnhavenLocationBackButton).Click += this.wijnhavenLocationBackButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.wijnhaven61Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Menus\WijnhavenLocations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.wijnhaven61Button).Click += this.wijnhaven61Button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.wijnhaven99Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Menus\WijnhavenLocations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.wijnhaven99Button).Click += this.wijnhaven99Button_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.wijnhaven103Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Menus\WijnhavenLocations.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.wijnhaven103Button).Click += this.wijnhaven103Button_Click;
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

