﻿#pragma checksum "..\..\..\PopUpPassword\PopUpResetPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DAC0004EC28ECF639BD920FC75829390102EB746"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF.Overtime;


namespace WPF.Overtime {
    
    
    /// <summary>
    /// PopUpForgetPassword
    /// </summary>
    public partial class PopUpForgetPassword : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NewPass;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox textBoxNewPassword;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox textBoxReNewPassword;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF.Overtime;component/popuppassword/popupresetpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NewPass = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 13 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
            this.textBoxNewPassword.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxNewPassword_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxReNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 14 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
            this.textBoxReNewPassword.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxReNewPassword_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\PopUpPassword\PopUpResetPassword.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.buttonSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

