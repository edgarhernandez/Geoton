﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "663BA54734AB6BCE8425AEC8BDE82C21"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 195 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_respuesta;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_random;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\Window1.xaml"
        internal System.Windows.Controls.Grid grid_jueces;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btn_si;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btn_no;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\Window1.xaml"
        internal System.Windows.Controls.Grid grid_titulo;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_ronda;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\Window1.xaml"
        internal System.Windows.Controls.ListView List1;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\Window1.xaml"
        internal System.Windows.Controls.Grid grid_tiempo;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_tiempo;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btn_respuesta;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_pregunta;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\Window1.xaml"
        internal System.Windows.Controls.MediaElement me_bandera;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lbl_equipo;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label2;
        
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
            System.Uri resourceLocater = new System.Uri("/Geoton;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            
            #line 5 "..\..\Window1.xaml"
            ((Geoton.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl_respuesta = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbl_random = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.grid_jueces = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.btn_si = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\Window1.xaml"
            this.btn_si.Click += new System.Windows.RoutedEventHandler(this.btn_si_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_no = ((System.Windows.Controls.Button)(target));
            
            #line 212 "..\..\Window1.xaml"
            this.btn_no.Click += new System.Windows.RoutedEventHandler(this.btn_no_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.grid_titulo = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lbl_ronda = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.List1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.grid_tiempo = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.lbl_tiempo = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.btn_respuesta = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\Window1.xaml"
            this.btn_respuesta.Click += new System.Windows.RoutedEventHandler(this.btn_respuesta_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.lbl_pregunta = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.me_bandera = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 18:
            
            #line 243 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_salir);
            
            #line default
            #line hidden
            return;
            case 19:
            this.lbl_equipo = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
