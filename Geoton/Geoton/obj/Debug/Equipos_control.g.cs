﻿#pragma checksum "..\..\Equipos_control.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8BC3CCDDC7E029B1604283AB5BDDC947"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Expression.Interactivity.Core;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;
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
    /// Equipos_control
    /// </summary>
    public partial class Equipos_control : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 149 "..\..\Equipos_control.xaml"
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_reload;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_eliminar;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_agregar;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.TextBox txt_nombre_equipo;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_elimina_todo;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Label lbl_mensaje;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.ListView List1;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_arriba;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\Equipos_control.xaml"
        internal System.Windows.Controls.Button btn_reset;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Geoton;component/equipos_control.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Equipos_control.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\Equipos_control.xaml"
            ((Geoton.Equipos_control)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 5 "..\..\Equipos_control.xaml"
            ((Geoton.Equipos_control)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(target));
            return;
            case 3:
            this.btn_reload = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\Equipos_control.xaml"
            this.btn_reload.Click += new System.Windows.RoutedEventHandler(this.btn_reload_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\Equipos_control.xaml"
            this.btn_eliminar.Click += new System.Windows.RoutedEventHandler(this.btn_eliminar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_agregar = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\Equipos_control.xaml"
            this.btn_agregar.Click += new System.Windows.RoutedEventHandler(this.btn_agregar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_nombre_equipo = ((System.Windows.Controls.TextBox)(target));
            
            #line 155 "..\..\Equipos_control.xaml"
            this.txt_nombre_equipo.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_nombre_equipo_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.btn_elimina_todo = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\Equipos_control.xaml"
            this.btn_elimina_todo.Click += new System.Windows.RoutedEventHandler(this.btn_elimina_todo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_mensaje = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.List1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.btn_arriba = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\Equipos_control.xaml"
            this.btn_arriba.Click += new System.Windows.RoutedEventHandler(this.btn_arriba_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_reset = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\Equipos_control.xaml"
            this.btn_reset.Click += new System.Windows.RoutedEventHandler(this.btn_reset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
