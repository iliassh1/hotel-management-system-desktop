﻿#pragma checksum "..\..\Page_Buchung.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44A5C451C18C018B10C0044F16EEC0789DD6B016"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Hotel_Management_WPF;
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


namespace Hotel_Management_WPF {
    
    
    /// <summary>
    /// Page_Buchung
    /// </summary>
    public partial class Page_Buchung : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_name;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_vorname;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_telefon;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbx_sonstige;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_geb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_von;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_bis;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_preis;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_buchung;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmd_abb;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbx_zimmer;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Page_Buchung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Pass;
        
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
            System.Uri resourceLocater = new System.Uri("/Hotel_Management_WPF;component/page_buchung.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page_Buchung.xaml"
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
            
            #line 11 "..\..\Page_Buchung.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_vorname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_telefon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cmbx_sonstige = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\Page_Buchung.xaml"
            this.cmbx_sonstige.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbx_sonstige_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\Page_Buchung.xaml"
            this.cmbx_sonstige.DropDownClosed += new System.EventHandler(this.cmbx_sonstige_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dp_geb = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.dp_von = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.dp_bis = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.lbl_preis = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lbl_buchung = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            
            #line 41 "..\..\Page_Buchung.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.cmd_abb = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Page_Buchung.xaml"
            this.cmd_abb.Click += new System.Windows.RoutedEventHandler(this.cmd_abb_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cmbx_zimmer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\Page_Buchung.xaml"
            this.cmbx_zimmer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbx_zimmer_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 43 "..\..\Page_Buchung.xaml"
            this.cmbx_zimmer.DropDownClosed += new System.EventHandler(this.cmbx_zimmer_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txt_Pass = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\Page_Buchung.xaml"
            this.txt_Pass.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_name_Copy_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

