using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;
using System.Xml;

namespace Geoton
{
    /// <summary>
    /// Interaction logic for Equipos_control.xaml
    /// </summary>
    public partial class Equipos_control : Window
    {
        Equipos dedo = new Equipos();
        public Equipos_control()
        {
            InitializeComponent();
        }

        private void btn_reload_Click(object sender, RoutedEventArgs e)
        {

            Cargar_equipos();

        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            eliminar_equipo();
        }

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            //dedo.con_net();
            agregar_equipo();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            dedo.puntaje();
            Cargar_equipos();
        }

        private void btn_elimina_todo_Click(object sender, RoutedEventArgs e)
        {
            eliminar_todo();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cargar_equipos();
            txt_nombre_equipo.Focus();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_arriba_Click(object sender, RoutedEventArgs e)
        {
            mueve_arriba();
        }

        private void Cargar_equipos()
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(@"BD\Equipos.xml");
            DataTable dt = new DataTable();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"BD\Equipos.xml");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            if (dataSet.Tables.Count > 0)
                List1.DataContext = dataSet.Tables[0].DefaultView;
            else                
            cuentalos();
        }

        private void agregar_equipo()
        {
            if (txt_nombre_equipo.Text.Length > 0)
            {
                if (txt_nombre_equipo.Text.Length < 20)
                {
                    dedo.insertar(txt_nombre_equipo.Text.ToUpper());
                    txt_nombre_equipo.Text = "";
                    Cargar_equipos();
                }
                else
                {
                    MessageBox.Show("Nombre demaciado Largo");

                }
            }
            else
                MessageBox.Show("No hay Nombre de Equipo");
            txt_nombre_equipo.Focus();

            cuentalos();
        }

        private void eliminar_equipo()
        {
            int yo = int.Parse(List1.SelectedIndex.ToString());
            string id_eliminado = (yo + 1).ToString();
            if ((yo + 1) > 0)
            {
                int how = dedo.cuenta() - 1;
                dedo.eliminar(id_eliminado);
                if ((yo + 1) != how)
                    dedo.reacomodo();
            }
            else
                MessageBox.Show("Debe seleccionar un equipo para eliminarlo.");
            Cargar_equipos();
            cuentalos();
        }

        private void eliminar_todo()
        {
            dedo.elimina_todo();
            cuentalos();
        }

        private void cuentalos()
        {
            int how = dedo.cuenta() -1;
            if (how > 0)
            {
                lbl_mensaje.Visibility = Visibility.Hidden;
                List1.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_mensaje.Visibility = Visibility.Visible;
                List1.Visibility = Visibility.Hidden;
            }
        }

        private void reset_pun()
        {
            dedo.reset_puntaje();
            Cargar_equipos();
        }

        private void mueve_arriba()
        {
            int yo = int.Parse(List1.SelectedIndex.ToString());
            string mueveme = (yo + 1).ToString();
            if ((yo + 1) > 1)
            {                
                dedo.mueve_arriba(mueveme);               
            }
           // else
                //MessageBox.Show("Debe seleccionar un equipo para eliminarlo");
            Cargar_equipos();
            //cuentalos();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            reset_pun();
        }

        private void txt_nombre_equipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                agregar_equipo();
            }
        }

        private void btn_aceptar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	Close();// TODO: Add event handler implementation here.
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


    }
}
