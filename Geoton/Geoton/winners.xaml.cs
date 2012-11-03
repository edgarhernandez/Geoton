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

namespace Geoton
{
    /// <summary>
    /// Interaction logic for winners.xaml
    /// </summary>
    public partial class winners : Window
    {
        Equipos lugares = new Equipos();

        string[] nombres = new string[3];
        int[] puntos = new int[3];


        public winners()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void lugar()
        {
            int[] place = lugares.lugares();

            for (int i = 0; i < 3; i++)
            {
                nombres[i] =  lugares.dime_equipo(place[i].ToString());
                puntos[i] = int.Parse((lugares.dime_puntaje(place[i].ToString())).ToString());
            }

            lbl_primero.Content = nombres[0];
            lbl_segundo.Content = nombres[1];
            lbl_tercero.Content = nombres[2];

            lbl_1.Content = puntos[0].ToString();
            lbl_2.Content = puntos[1].ToString();
            lbl_3.Content = puntos[2].ToString();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lugar();
        }

        private void btn_cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
