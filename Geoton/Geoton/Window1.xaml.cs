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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;
using System.Xml;

namespace Geoton
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //List numeros_sacados;
        Equipos equipo = new Equipos();

        int vamos_rondas = 0;
        int vamos_equipo = 0;

        int num_ronditas;
        int num_equipos;
        
        Consultas_paises consulta_pais = new Consultas_paises();
        Consultas_abiertas consulta_abierta = new Consultas_abiertas();
        System.Windows.Forms.Timer tiempo = new System.Windows.Forms.Timer();


        List<int> numeros_sacados = new List<int>();
        List<int> numeros_capitales = new List<int>();
        List<int> numeros_continentes = new List<int>();
        List<int> numeros_idiomas = new List<int>();
        List<int> numeros_monedas = new List<int>();
        List<int> numeros_gobiernos = new List<int>();
        List<int> numeros_nombresoficiales = new List<int>();
        List<int> numeros_banderas = new List<int>();
        List<int> numeros_gentilicios = new List<int>();
        List<int> numeros_abiertos = new List<int>();
        Random esto = new Random();
        int cantidad_paises;
        int cantidad_abiertos;
        int tiempos;

        //string form_pregunta=null;
        //string form_respuesta=null;

        //string pais = null;

        public Window1(int num_rondas, int numero_equipos)
        {
            

            num_ronditas = num_rondas;
            num_equipos = numero_equipos;
            InitializeComponent();
        }

        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            tiempos = tiempos -1;
            lbl_tiempo.Content = tiempos.ToString();
            if(tiempos==0)
                tiempo.Stop();
                
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tiempo.Interval = 1000;
            tiempo.Tick += new EventHandler(Timer_Tick);
            //MessageBox.Show(num_ronditas.ToString());
            Cargar_equipos();
            cuenta_paises();
            control_rondas();
        }

        private void control_rondas()
        {
            vamos_equipo = 1;
            vamos_rondas = 1;
            has_preguntas();
        }

        private void has_preguntas()
        {
            //btn_si.Visibility = Visibility.Collapsed;
            //btn_no.Visibility = Visibility.Collapsed;
            grid_jueces.Visibility = Visibility.Hidden;
            if (vamos_rondas > num_ronditas)
            {
                MessageBox.Show("Ha terminado el Juego, se mostrará la Tabla de Posiciones");
                winners win = new winners();
                win.Show();
                this.Close();
            }
            else
            {
                tiempos = 15;
                lbl_ronda.Content = vamos_rondas.ToString();
                lbl_equipo.Content = equipo.dime_equipo(vamos_equipo.ToString());
                inicio();
                vamos_equipo = vamos_equipo +1;
                if (vamos_equipo > num_equipos)
                {
                    vamos_equipo = 1;
                    vamos_rondas = vamos_rondas + 1;
                    //if (vamos_rondas > num_ronditas)
                    //{
                    //    MessageBox.Show("Se supone que termina");
                    //}
                }
                tiempo.Start();
            }

        }



        #region Control de Preguntas

        private void inicio()
        {
            int tipo = tipo_pregunta();
            int id_pais;
            int id_abierto;
            string pregunta;
            string respuesta;
            String URLi = String.Format(@"flags\none.png");
            me_bandera.Source = new Uri(URLi, UriKind.Relative); 
            //MessageBox.Show(tipo.ToString());
            switch (tipo)
            {
                case 1://¿Cual es la capital de_______?                    
                    //me_bandera.Visibility = Visibility.Hidden;
                    // = Properties.Resources.pregunta_chida;
                     
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_capital();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.capital_respuesta(id_pais);
                    lbl_pregunta.Content = "¿Cuál es la Capital de " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 2://¿En qué Continente de encuentra ____________?
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_continente();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.continente_respuesta(id_pais);
                    lbl_pregunta.Content = "¿En qué Continente se encuentra " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 3://¿Cuál es el idioma oficial de____--?
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_idioma();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.idioma_oficial_respuesta(id_pais);
                    lbl_pregunta.Content = "¿Cuál es el idioma oficial de " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 4://¿Cuál es la moneda de ____?
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_moneda();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.moneda_respuesta(id_pais);
                    lbl_pregunta.Content = "¿Cuál es la Moneda de " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                //case 5://¿Qué tipo de Gobierno tiene ____?
                //    //me_bandera.Visibility = Visibility.Hidden;
                //    lbl_respuesta.Visibility = Visibility.Hidden;
                //    id_pais = motor_gobierno();
                //    pregunta = consulta_pais.pais_pregunta(id_pais);
                //    respuesta = consulta_pais.gobierno_respuesta(id_pais);
                //    lbl_pregunta.Content = "¿Qué tipo de Gobierno tiene " + pregunta + " ?";
                //    lbl_respuesta.Content = "Respuesta : " + respuesta;
                //    break;

                case 5://¿Cuál es el Nombre Oficial de ____?
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_nombreoficial();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.nombre_oficial_respuesta(id_pais);
                    lbl_pregunta.Content = "¿Cuál es el Nombre Oficial de " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 6://¿A qué país corresponde esta Bandera?mostrar bandera
                    //me_bandera.Visibility = Visibility.Visible;
                    id_pais = motor_bandera();
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    respuesta = consulta_pais.pais_pregunta(id_pais);
                    string banderita = consulta_pais.bandera_respuesta(id_pais);
                    lbl_pregunta.Content = "¿A qué país corresponde esta Bandera?";
                    String URL = String.Format(@"flags\{0}", banderita);
                    me_bandera.Source = new Uri(URL, UriKind.Relative);                    
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 7://¿¿Cuál es el Gentilicio de ____?
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_pais = motor_gentilicio();
                    pregunta = consulta_pais.pais_pregunta(id_pais);
                    respuesta = consulta_pais.gentilicio_respuesta(id_pais);
                    lbl_pregunta.Content = "¿Cuál es el Gentilicio de " + pregunta + " ?";
                    lbl_respuesta.Content = "Respuesta : " + respuesta;
                    break;

                case 8://Preguntas abiertas
                    //me_bandera.Visibility = Visibility.Hidden;
                    lbl_respuesta.Visibility = Visibility.Hidden;
                    id_abierto = motor_abiertos();
                    if (id_abierto ==0)
                    {
                        lbl_pregunta.Content = "Ganaste un punto";
                        lbl_respuesta.Content = "Si ganaste un Punto";
                    }
                    else
                    {
                           pregunta = consulta_abierta.pregunta_abierta(id_abierto);
                           respuesta = consulta_abierta.respuesta_abierta(id_abierto);
                           lbl_pregunta.Content = pregunta;
                           lbl_respuesta.Content = "Respuesta : " + respuesta;
                    }
                    break;
            }
        }

        private int tipo_pregunta()
        {
            int numro;
            numro = esto.Next(1, 9);
            return numro;
        }
        
        private int motor_capital()
        {
            int mi_num=0;  
            if (numeros_capitales.Count <= (cantidad_paises -1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_capitales.IndexOf(mi_num) != -1);
                numeros_capitales.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de capitales";
            }
            return mi_num;
        }

        private int motor_continente()
        {
            int mi_num = 0;
            if (numeros_continentes.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_continentes.IndexOf(mi_num) != -1);
                numeros_continentes.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Continentes";
            }
            return mi_num;
        }

        private int motor_idioma()
        {
            int mi_num = 0;
            if (numeros_idiomas.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_idiomas.IndexOf(mi_num) != -1);
                numeros_idiomas.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Idiomas";
            }
            return mi_num;
        }

        private int motor_moneda()
        {
            int mi_num = 0;
            if (numeros_monedas.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_monedas.IndexOf(mi_num) != -1);
                numeros_monedas.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Monedas";
            }
            return mi_num;
        }

        private int motor_gobierno()
        {
            int mi_num = 0;
            if (numeros_gobiernos.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_gobiernos.IndexOf(mi_num) != -1);
                numeros_gobiernos.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Tipo de Gobiernos";
            }
            return mi_num;
        }

        private int motor_nombreoficial()
        {
            int mi_num = 0;
            if (numeros_nombresoficiales.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_nombresoficiales.IndexOf(mi_num) != -1);
                numeros_nombresoficiales.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Nombres Oficiales";
            }
            return mi_num;
        }

        private int motor_gentilicio()
        {
            int mi_num = 0;
            if (numeros_gentilicios.Count<= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_gentilicios.IndexOf(mi_num) != -1);
                numeros_gentilicios.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Gentilicios";
            }
            return mi_num;
        }

        private int motor_bandera()
        {
            int mi_num = 0;
            if (numeros_banderas.Count <= (cantidad_paises - 1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_banderas.IndexOf(mi_num) != -1);
                numeros_banderas.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Banderas";
                mi_num = 0;
            }
            return mi_num;
        }

        private int motor_abiertos()
        {
            int mi_num = 0;
            if (numeros_abiertos.Count <= (cantidad_abiertos - 1))
            {
                do
                {
                    mi_num = generar_abiertos();
                } while (numeros_abiertos.IndexOf(mi_num) != -1);
                numeros_abiertos.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Ya no hay mas preguntas de Banderas";
            }
            return mi_num;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // se define un string con la ruta donde esta el archivo de excel 
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source= C:\\Datos.xls ;Extended Properties= ""Excel 8.0;HDR=YES;""";
            //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Proyecto Sanabria\Geoton\Geoton\bin\Debug\BD\preguntas.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\preguntas.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";


            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            // se instancia la conexion             
            DbConnection conexion = factory.CreateConnection();

            // se instancia el comando 
            DbCommand comando = conexion.CreateCommand();

            // se asigna el string con la conexion 
            conexion.ConnectionString = connectionString;

            // se asigna la consulta  
            //comando.CommandText = "SELECT ID,NOMBRE FROM [hoja1$]";
            comando.CommandText = "SELECT COUNT(IDPAIS) AS I FROM [paises$]";

            conexion.Open();

            int[] ides;
            string[] names;
            //DataTable edgar = comando.ExecuteReader();
            DbDataReader dr = comando.ExecuteReader();

            ides = new int[dr.VisibleFieldCount];
            names = new string[dr.VisibleFieldCount];

            int y=0;
            while (dr.Read())
            {
                ides[0] = int.Parse(dr["IDPAIS"].ToString()); 
                //names[y]=dr["NOMBRE"].ToString();
                //dr["NOMBRE"].ToString());
                y = y + 1;
            }

            //lbl_contra.Content = ides[0].ToString();
            //lbl_name.Content= names[0].ToString();

            //DataRow rows;

            conexion.Close();

            //lbl_contra.Content =                         
        }

        private void genera_random()
        {
            Random ran = new Random();
            lbl_random.Content = ran.Next(1, 8);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            inicio();
            //cuenta_paises();
            //genera_random();
            //motor();
        }

        private void motor()
        {
            int mi_num=0;  
            if (numeros_sacados.Count <= (cantidad_paises-1))
            {
                do
                {
                    mi_num = generar();
                } while (numeros_sacados.IndexOf(mi_num) != -1);
                numeros_sacados.Add(mi_num);
                lbl_random.Content = mi_num.ToString();
            }
            else
            {
                lbl_random.Content = "Se acabaron los numeros";
            }

        }

        private int generar()
        {
            int numro;            
            numro = esto.Next(1, cantidad_paises+1);          
            return numro;
        }

        private int generar_abiertos()
        {
            int numro;
            numro = esto.Next(1, cantidad_abiertos + 1);
            return numro;
        }

        private void cuenta_paises()
        {
           cantidad_paises = consulta_pais.cuenta_paises();
           cantidad_abiertos = consulta_abierta.cuenta_abiertos();                
        }

        private void btn_respuesta_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
            lbl_respuesta.Visibility = Visibility.Visible;
            //btn_si.Visibility = Visibility.Visible;
            //btn_no.Visibility = Visibility.Visible;
            grid_jueces.Visibility = Visibility.Visible;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Equipos EQ = new Equipos();
            //EQ.conecta();
            //EQ.con_net();

            Equipos_control control = new Equipos_control();
            control.Visibility = Visibility.Visible;
        }

        #endregion

        private void btn_si_Click(object sender, RoutedEventArgs e)
        {            
            if (vamos_equipo == 1)
            {
                equipo.puntaje_agrega(num_equipos.ToString());
            }
            else
            {
                equipo.puntaje_agrega((vamos_equipo - 1).ToString());
            }
            Cargar_equipos();
            has_preguntas();
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
            
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            has_preguntas();
        }

        private void btn_salir(object sender, System.Windows.RoutedEventArgs e)
        {
        	Close();// TODO: Add event handler implementation here.
        }
    }
}
