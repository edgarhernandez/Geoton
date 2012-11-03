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
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace Geoton
{
    /// <summary>
    /// Interaction logic for Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        //System.Windows.SplashScreen splash = new System.Windows.SplashScreen("Hidrosoft_s.jpg");
        

        int num_equipos;
        Equipos equipo = new Equipos();
        public Inicio()
        {
   
               //splash.Show(false);
   
               //splash.Close(new TimeSpan(0, 0, 6));


            InitializeComponent();

        }

        private void btn_inicio_Click(object sender, RoutedEventArgs e)
        {
            num_equipos = equipo.cuenta() - 1;
            if (num_equipos >= 3)
            {
                if (txt_rondas.Text.Length > 0)
                {
                    Window1 concurso = new Window1(int.Parse(txt_rondas.Text), num_equipos);
                    txt_rondas.Text = "";
                    concurso.Show();
                }
                else
                {
                    MessageBox.Show("No hay número de Rondas");
                }
            }
            else
            {
                MessageBox.Show("Se Requieren Mínimo 3 equipos");
            }
        }

        private void btn_equipos_Click(object sender, RoutedEventArgs e)
        {
            Equipos_control alta = new Equipos_control();
            alta.Show();
        }

        private void txt_rondas_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.Key.ToString());

            //7MessageBox.Show(e.InputSource.ToString());
            if (e.Key == Key.Enter & txt_rondas.Text.Length>0)
            {
                btn_equipos.Focus();
            }
            else
            {
                if (e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4
                    || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9
                    || e.Key == Key.Tab)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            About aboutt = new About();
            aboutt.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_rondas.Focus();
        }

        private void btn_config_Click(object sender, RoutedEventArgs e)
        {
            login pass = new login();
            pass.Show();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        
    }
}
