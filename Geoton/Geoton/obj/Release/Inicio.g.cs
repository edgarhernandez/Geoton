﻿#pragma checksum "..\..\Inicio.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F36BF005838C7685512365AF24259002"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Geoton;
using Microsoft.Expression.Interactivity.Core;
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


namespace Geoton {
    
    
    /// <summary>
    /// Inicio
    /// </summary>
    public partial class Inicio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 272 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_equipos;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_inicio;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_about;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 310 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_rondas;
        
        #line default
        #line hidden
        
        
        #line 312 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_config;
        
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
            System.Uri resourceLocater = new System.Uri("/Geoton;component/inicio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Inicio.xaml"
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
            
            #line 5 "..\..\Inicio.xaml"
            ((Geoton.Inicio)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 5 "..\..\Inicio.xaml"
            ((Geoton.Inicio)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(target));
            return;
            case 3:
            this.btn_equipos = ((System.Windows.Controls.Button)(target));
            
            #line 279 "..\..\Inicio.xaml"
            this.btn_equipos.Click += new System.Windows.RoutedEventHandler(this.btn_equipos_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_inicio = ((System.Windows.Controls.Button)(target));
            
            #line 289 "..\..\Inicio.xaml"
            this.btn_inicio.Click += new System.Windows.RoutedEventHandler(this.btn_inicio_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_about = ((System.Windows.Controls.Button)(target));
            
            #line 307 "..\..\Inicio.xaml"
            this.btn_about.Click += new System.Windows.RoutedEventHandler(this.btn_about_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txt_rondas = ((System.Windows.Controls.TextBox)(target));
            
            #line 310 "..\..\Inicio.xaml"
            this.txt_rondas.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_rondas_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 312 "..\..\Inicio.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_config = ((System.Windows.Controls.Button)(target));
            
            #line 317 "..\..\Inicio.xaml"
            this.btn_config.Click += new System.Windows.RoutedEventHandler(this.btn_config_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

