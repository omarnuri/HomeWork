﻿#pragma checksum "..\..\..\..\..\View\Windows\Registration_Windows.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F58CE62D3B93AF4FAFEAA4388B84948D52C32904"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Exam_WPF.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Exam_WPF.View {
    
    
    /// <summary>
    /// Registration_Windows
    /// </summary>
    public partial class Registration_Windows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Blocks;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Reg_Name;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Reg_SureName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Reg_Login;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Reg_Password;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Reg_Password_hidden;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Error_Message_Text;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reg_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Exam_WPF_Fix;V1.0.0.0;component/view/windows/registration_windows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Blocks = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Reg_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChecker);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Reg_SureName = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_SureName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChecker);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Reg_Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChecker);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Reg_Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_Password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChecker);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Reg_Password_hidden = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 20 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_Password_hidden.PasswordChanged += new System.Windows.RoutedEventHandler(this.Reg_Password_hidden_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Error_Message_Text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Reg_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            this.Reg_Button.Click += new System.Windows.RoutedEventHandler(this.Register_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 25 "..\..\..\..\..\View\Windows\Registration_Windows.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HideShowButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

