﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Jaar_1_Project_4
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[29];
            _typeNameTable[0] = "Jaar_1_Project_4.Activities";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "Jaar_1_Project_4.ContactPagePopup";
            _typeNameTable[4] = "Jaar_1_Project_4.CreateAccount";
            _typeNameTable[5] = "Jaar_1_Project_4.HelpPage";
            _typeNameTable[6] = "Jaar_1_Project_4.ContactPage";
            _typeNameTable[7] = "Jaar_1_Project_4.Answer";
            _typeNameTable[8] = "Jaar_1_Project_4.QuestionSystem.mainQpage";
            _typeNameTable[9] = "Jaar_1_Project_4.QuestionSystem.QandAPage";
            _typeNameTable[10] = "Jaar_1_Project_4.ActivityPopup";
            _typeNameTable[11] = "Jaar_1_Project_4.Wijnhaven107Education";
            _typeNameTable[12] = "Jaar_1_Project_4.Wijnhaven107";
            _typeNameTable[13] = "Jaar_1_Project_4.FourthFloor";
            _typeNameTable[14] = "Jaar_1_Project_4.MainMenu";
            _typeNameTable[15] = "Jaar_1_Project_4.MainLoginPage";
            _typeNameTable[16] = "Jaar_1_Project_4.OpenDagInformatie";
            _typeNameTable[17] = "Jaar_1_Project_4.Questions";
            _typeNameTable[18] = "Jaar_1_Project_4.SecondFloor";
            _typeNameTable[19] = "Jaar_1_Project_4.StudentLogin";
            _typeNameTable[20] = "Jaar_1_Project_4.TeacherLogIn";
            _typeNameTable[21] = "Jaar_1_Project_4.ThirthFloor";
            _typeNameTable[22] = "Jaar_1_Project_4.Wijnhaven103";
            _typeNameTable[23] = "Jaar_1_Project_4.Wijnhaven61";
            _typeNameTable[24] = "Jaar_1_Project_4.Wijnhaven61Education";
            _typeNameTable[25] = "Jaar_1_Project_4.Wijnhaven99";
            _typeNameTable[26] = "Jaar_1_Project_4.Wijnhaven99Education";
            _typeNameTable[27] = "Jaar_1_Project_4.WijnhavenLocations";
            _typeNameTable[28] = "Jaar_1_Project_4.WijnhavenEducationPopup";

            _typeTable = new global::System.Type[29];
            _typeTable[0] = typeof(global::Jaar_1_Project_4.Activities);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::Jaar_1_Project_4.ContactPagePopup);
            _typeTable[4] = typeof(global::Jaar_1_Project_4.CreateAccount);
            _typeTable[5] = typeof(global::Jaar_1_Project_4.HelpPage);
            _typeTable[6] = typeof(global::Jaar_1_Project_4.ContactPage);
            _typeTable[7] = typeof(global::Jaar_1_Project_4.Answer);
            _typeTable[8] = typeof(global::Jaar_1_Project_4.QuestionSystem.mainQpage);
            _typeTable[9] = typeof(global::Jaar_1_Project_4.QuestionSystem.QandAPage);
            _typeTable[10] = typeof(global::Jaar_1_Project_4.ActivityPopup);
            _typeTable[11] = typeof(global::Jaar_1_Project_4.Wijnhaven107Education);
            _typeTable[12] = typeof(global::Jaar_1_Project_4.Wijnhaven107);
            _typeTable[13] = typeof(global::Jaar_1_Project_4.FourthFloor);
            _typeTable[14] = typeof(global::Jaar_1_Project_4.MainMenu);
            _typeTable[15] = typeof(global::Jaar_1_Project_4.MainLoginPage);
            _typeTable[16] = typeof(global::Jaar_1_Project_4.OpenDagInformatie);
            _typeTable[17] = typeof(global::Jaar_1_Project_4.Questions);
            _typeTable[18] = typeof(global::Jaar_1_Project_4.SecondFloor);
            _typeTable[19] = typeof(global::Jaar_1_Project_4.StudentLogin);
            _typeTable[20] = typeof(global::Jaar_1_Project_4.TeacherLogIn);
            _typeTable[21] = typeof(global::Jaar_1_Project_4.ThirthFloor);
            _typeTable[22] = typeof(global::Jaar_1_Project_4.Wijnhaven103);
            _typeTable[23] = typeof(global::Jaar_1_Project_4.Wijnhaven61);
            _typeTable[24] = typeof(global::Jaar_1_Project_4.Wijnhaven61Education);
            _typeTable[25] = typeof(global::Jaar_1_Project_4.Wijnhaven99);
            _typeTable[26] = typeof(global::Jaar_1_Project_4.Wijnhaven99Education);
            _typeTable[27] = typeof(global::Jaar_1_Project_4.WijnhavenLocations);
            _typeTable[28] = typeof(global::Jaar_1_Project_4.WijnhavenEducationPopup);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_Activities() { return new global::Jaar_1_Project_4.Activities(); }
        private object Activate_3_ContactPagePopup() { return new global::Jaar_1_Project_4.ContactPagePopup(); }
        private object Activate_4_CreateAccount() { return new global::Jaar_1_Project_4.CreateAccount(); }
        private object Activate_5_HelpPage() { return new global::Jaar_1_Project_4.HelpPage(); }
        private object Activate_6_ContactPage() { return new global::Jaar_1_Project_4.ContactPage(); }
        private object Activate_7_Answer() { return new global::Jaar_1_Project_4.Answer(); }
        private object Activate_8_mainQpage() { return new global::Jaar_1_Project_4.QuestionSystem.mainQpage(); }
        private object Activate_9_QandAPage() { return new global::Jaar_1_Project_4.QuestionSystem.QandAPage(); }
        private object Activate_10_ActivityPopup() { return new global::Jaar_1_Project_4.ActivityPopup(); }
        private object Activate_11_Wijnhaven107Education() { return new global::Jaar_1_Project_4.Wijnhaven107Education(); }
        private object Activate_12_Wijnhaven107() { return new global::Jaar_1_Project_4.Wijnhaven107(); }
        private object Activate_13_FourthFloor() { return new global::Jaar_1_Project_4.FourthFloor(); }
        private object Activate_14_MainMenu() { return new global::Jaar_1_Project_4.MainMenu(); }
        private object Activate_15_MainLoginPage() { return new global::Jaar_1_Project_4.MainLoginPage(); }
        private object Activate_16_OpenDagInformatie() { return new global::Jaar_1_Project_4.OpenDagInformatie(); }
        private object Activate_17_Questions() { return new global::Jaar_1_Project_4.Questions(); }
        private object Activate_18_SecondFloor() { return new global::Jaar_1_Project_4.SecondFloor(); }
        private object Activate_19_StudentLogin() { return new global::Jaar_1_Project_4.StudentLogin(); }
        private object Activate_20_TeacherLogIn() { return new global::Jaar_1_Project_4.TeacherLogIn(); }
        private object Activate_21_ThirthFloor() { return new global::Jaar_1_Project_4.ThirthFloor(); }
        private object Activate_22_Wijnhaven103() { return new global::Jaar_1_Project_4.Wijnhaven103(); }
        private object Activate_23_Wijnhaven61() { return new global::Jaar_1_Project_4.Wijnhaven61(); }
        private object Activate_24_Wijnhaven61Education() { return new global::Jaar_1_Project_4.Wijnhaven61Education(); }
        private object Activate_25_Wijnhaven99() { return new global::Jaar_1_Project_4.Wijnhaven99(); }
        private object Activate_26_Wijnhaven99Education() { return new global::Jaar_1_Project_4.Wijnhaven99Education(); }
        private object Activate_27_WijnhavenLocations() { return new global::Jaar_1_Project_4.WijnhavenLocations(); }
        private object Activate_28_WijnhavenEducationPopup() { return new global::Jaar_1_Project_4.WijnhavenEducationPopup(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Jaar_1_Project_4.Activities
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_Activities;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Jaar_1_Project_4.ContactPagePopup
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_ContactPagePopup;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Jaar_1_Project_4.CreateAccount
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_CreateAccount;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Jaar_1_Project_4.HelpPage
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_HelpPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  Jaar_1_Project_4.ContactPage
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_ContactPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  Jaar_1_Project_4.Answer
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_Answer;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Jaar_1_Project_4.QuestionSystem.mainQpage
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_mainQpage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Jaar_1_Project_4.QuestionSystem.QandAPage
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_QandAPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Jaar_1_Project_4.ActivityPopup
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_ActivityPopup;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  Jaar_1_Project_4.Wijnhaven107Education
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_Wijnhaven107Education;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Jaar_1_Project_4.Wijnhaven107
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Wijnhaven107;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  Jaar_1_Project_4.FourthFloor
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_FourthFloor;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  Jaar_1_Project_4.MainMenu
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_MainMenu;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  Jaar_1_Project_4.MainLoginPage
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_MainLoginPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  Jaar_1_Project_4.OpenDagInformatie
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_OpenDagInformatie;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  Jaar_1_Project_4.Questions
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_Questions;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  Jaar_1_Project_4.SecondFloor
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_SecondFloor;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  Jaar_1_Project_4.StudentLogin
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_StudentLogin;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  Jaar_1_Project_4.TeacherLogIn
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_20_TeacherLogIn;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  Jaar_1_Project_4.ThirthFloor
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_21_ThirthFloor;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  Jaar_1_Project_4.Wijnhaven103
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_22_Wijnhaven103;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 23:   //  Jaar_1_Project_4.Wijnhaven61
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_23_Wijnhaven61;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 24:   //  Jaar_1_Project_4.Wijnhaven61Education
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_24_Wijnhaven61Education;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 25:   //  Jaar_1_Project_4.Wijnhaven99
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_25_Wijnhaven99;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 26:   //  Jaar_1_Project_4.Wijnhaven99Education
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_26_Wijnhaven99Education;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 27:   //  Jaar_1_Project_4.WijnhavenLocations
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_27_WijnhavenLocations;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 28:   //  Jaar_1_Project_4.WijnhavenEducationPopup
                userType = new global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_28_WijnhavenEducationPopup;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }



        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlMember xamlMember = null;
            // No Local Properties
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlSystemBaseType
    {
        global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Jaar_1_Project_4.Jaar_1_Project_4_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

