<<<<<<< HEAD
﻿#pragma checksum "D:\Project\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\Activities\Activities.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "558F83AC182B988910261717E325BFEC"
=======
﻿#pragma checksum "C:\Users\ramon\Documents\GitHub\PROJECT4_fijn_uitgedosde_barbaren\Jaar 1 Project 4\Jaar 1 Project 4\Activities\Activities.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "558F83AC182B988910261717E325BFEC"
>>>>>>> origin/master
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
    partial class Activities : 
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
                    this.activities = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.mainTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.secondFloorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Activities\Activities.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.secondFloorButton).Click += this.secondFloorButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.thirdFloorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Activities\Activities.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.thirdFloorButton).Click += this.thirdFloorButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.fourthFloorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Activities\Activities.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.fourthFloorButton).Click += this.fourthFloorButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.activitiesBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\Activities\Activities.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.activitiesBackButton).Click += this.activitiesBackButton_Click;
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

