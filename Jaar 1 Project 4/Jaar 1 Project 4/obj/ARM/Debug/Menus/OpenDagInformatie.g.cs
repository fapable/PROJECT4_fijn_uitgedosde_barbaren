﻿#pragma checksum "B:\School\Hogeschool\Homework\Projecten\Project 4\githubClone\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\Menus\OpenDagInformatie.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B8F4FACB5690678DC7E5A3C9A8ED543E"
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
    partial class OpenDagInformatie : 
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
                    this.open_day_info = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.openDayInformation = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.activitiesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\Menus\OpenDagInformatie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.activitiesButton).Click += this.activitiesButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.educationButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Menus\OpenDagInformatie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.educationButton).Click += this.educationButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.locationsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Menus\OpenDagInformatie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.locationsButton).Click += this.locationsButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.openDayBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Menus\OpenDagInformatie.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.openDayBackButton).Click += this.openDayBackButton_Click;
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
