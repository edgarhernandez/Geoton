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
using System.Diagnostics;

namespace Geoton
{
    /// <summary>
    /// Interaction logic for Bases.xaml
    /// </summary>
    public partial class Bases : Window
    {
        public Bases()
        {
            InitializeComponent();
        }


        private void base_paises()
        {
            string filename = "Excel.exe";
            Process proc = new Process(); 
            proc.EnableRaisingEvents = false; 
            proc.StartInfo.FileName = filename; 
            proc.StartInfo.Arguments = @"BD\pais.xlsx"; 
            proc.Start(); 
        }

        private void base_abiertas()
        {
            string filename = "Excel.exe";
            Process proc = new Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = filename;
            proc.StartInfo.Arguments = @"BD\abiertas.xlsx";
            proc.Start();
        }

        private void btn_paises_Click(object sender, RoutedEventArgs e)
        {
            base_paises();
        }

        private void btn_abiertas_Click(object sender, RoutedEventArgs e)
        {
            base_abiertas();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
