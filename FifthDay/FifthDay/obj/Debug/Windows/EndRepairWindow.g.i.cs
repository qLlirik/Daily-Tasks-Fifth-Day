﻿#pragma checksum "..\..\..\Windows\EndRepairWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3432BE0DBAB172B6DA430486D6E13A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FifthDay.Windows;
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


namespace FifthDay.Windows {
    
    
    /// <summary>
    /// EndRepairWindow
    /// </summary>
    public partial class EndRepairWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxPeriod;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxComment;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxCostRepair;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\EndRepairWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxGuarantee;
        
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
            System.Uri resourceLocater = new System.Uri("/FifthDay;component/windows/endrepairwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EndRepairWindow.xaml"
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
            
            #line 11 "..\..\..\Windows\EndRepairWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            
            #line 16 "..\..\..\Windows\EndRepairWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Search);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbxPeriod = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Windows\EndRepairWindow.xaml"
            this.cbxPeriod.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.select_cbxPeriod);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lv = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.tbxComment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxCostRepair = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbxGuarantee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 108 "..\..\..\Windows\EndRepairWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_End);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

