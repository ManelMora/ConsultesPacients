﻿#pragma checksum "..\..\..\ModificarVisitaWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F5C9CC8215AE1345B9C1CD6C3046A7230129535"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ConsultesPacients;
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


namespace ConsultesPacients {
    
    
    /// <summary>
    /// ModificarVisitaWindow
    /// </summary>
    public partial class ModificarVisitaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPacient;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorPacient;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtDataVisita;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorDataVisita;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMotiu;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorMotiu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ModificarVisitaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAplicarCanvis;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ConsultesPacients;component/modificarvisitawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ModificarVisitaWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtPacient = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\ModificarVisitaWindow.xaml"
            this.txtPacient.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblErrorPacient = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtDataVisita = ((System.Windows.Controls.DatePicker)(target));
            
            #line 19 "..\..\..\ModificarVisitaWindow.xaml"
            this.txtDataVisita.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblErrorDataVisita = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtMotiu = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\ModificarVisitaWindow.xaml"
            this.txtMotiu.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblErrorMotiu = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnAplicarCanvis = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ModificarVisitaWindow.xaml"
            this.btnAplicarCanvis.Click += new System.Windows.RoutedEventHandler(this.AplicarCanvis_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 33 "..\..\..\ModificarVisitaWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

