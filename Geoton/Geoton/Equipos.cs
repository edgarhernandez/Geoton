using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

using System.Security;
using System.Security.Permissions;
//using ADSSECURITYLib;
using ActiveDs;

using System.Data;

namespace Geoton
{
    class Equipos
    {
        //public SqlConnection conexionn;

        XmlDocument documento = new XmlDocument();
       
        //const string URL = App.Current.StartupUri.ToString();

        //const string perro = URL.ToString();

        public void conecta()
        {
            //string file = Server.MapPath(@"pruebaExcel.xls");
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0;'";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\equipos.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            System.Data.OleDb.OleDbConnection oCon = new System.Data.OleDb.OleDbConnection(connectionString);
            oCon.Open();
            //string q = "INSERT INTO [EQUIPOS$B1:B1] VALUES (1)";
            string q = "INSERT INTO TEAM ([ID_EQUIPO], [NOMBRE_EQUIPO], [PUNTAJE]) VALUES (1,4,3)";
            int r = new System.Data.OleDb.OleDbCommand(q, oCon).ExecuteNonQuery();
            oCon.Close();
        }

        public void con_net()
        {
            System.Data.OleDb.OleDbConnection objConn = new System.Data.OleDb.OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\equipos.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");
            objConn.Open();
            System.Data.OleDb.OleDbCommand objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = "Insert into edgarin (ID_EQUIPO, NOMBRE_EQUIPO, PUNTAJE)" +
                " values (1, 'edgar',0)";
            objCmd.ExecuteNonQuery();
            objConn.Close(); 
        }



        public DataTable info()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\equipos.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT * FROM [EQUIPO$] ";
            conexion.Open();            
            DbDataReader dr = comando.ExecuteReader();           
            //DataTable dt;// = dr.GetSchemaTable();

            DataTable dt = new DataTable();// = dr.GetSchemaTable();

            dt.Load(dr);
           

            //////for (int i = 0; i < dr.FieldCount; i++)
            //////{
            //////    dt.Columns.Add(dr.GetName(i).ToString(),typeof(string));
            //////}

            
            //////while (dr.Read())
            //////{
            //////    //var row = dt.NewRow();
                
            //////    //row["ID_EQUIPO"] = dr["ID_EQUIPO"].ToString();
            //////    //row["NOMBRE_EQUIPO"] = dr["NOMBRE_EQUIPO"].ToString();
            //////    //row["PUNTAJE"] = dr["PUNTAJE"].ToString();
            //////    //dt.Rows.Add(row);
            //////    dt.Rows.Add(dr["ID_EQUIPO"].ToString(),dr["NOMBRE_EQUIPO"].ToString(),dr["PUNTAJE"].ToString());
            //////}

            //while (dr.Read())
            //{
            //    pregunta = dr["PAIS"].ToString();
            //}
            conexion.Close();
            return dt;
        }        
        
        public void borra_equipo(int id)
        {
            System.Data.OleDb.OleDbConnection objConn = new System.Data.OleDb.OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\equipos.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");
            objConn.Open();
            System.Data.OleDb.OleDbCommand objCmd = new System.Data.OleDb.OleDbCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = "Delete A4 from EQUIPO";
            objCmd.ExecuteNonQuery();
            objConn.Close(); 
        }



        //[FileIOPermission(SecurityAction.Demand, Read = @"C:\Windows\")]
        //[FileIOPermission(SecurityAction.Demand,Write= @"C:\")]
        //[FileIOPermission(SecurityAction.Demand, Write = @"C:\Program Files\HB CONSULTING\GEOTON-UVM\")]
        //[FileIOPermission(SecurityAction.Demand, Write = @"C:\Program Files\HB CONSULTING\GEOTON-UVM\BD\Equipos.xml")]
        
        //[PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        [FileIOPermission(SecurityAction.Demand, Write = @"C:\\Program Files (x86)\HB CONSULTING\GEOTON-UVM\BD")]
        public void insertar(string name)
        {
            //abre_base();
            
            //AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            //AppDomain.CurrentDomain.SetAppDomainPolicy(PolicyLevelType.User);


            //PrincipalPermission pp = new PrincipalPermission(null, @"BUILTIN\Users");
            //pp.Demand();
            //MessageBox.Show(URL);
            //FileIOPermission f2 = new FileIOPermission(FileIOPermissionAccess.Read, "C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml");
            //f2.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, "C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml");
            //try
            //{
            //    f2.Demand();
            //}
            //catch (SecurityException s)
            //{
            //    MessageBox.Show(s.Message.ToString());
            //}

            //FileIOPermission permFileIO = new FileIOPermission(FileIOPermissionAccess.AllAccess, "C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml");
            //try
            //{
            //    // Demand the permission to access the C:\Temp folder.
            //    permFileIO.Demand();
            //}
            //catch (SecurityException se)
            //{
            //    MessageBox.Show(se.Message.ToString());
            //}


            try
            {
                string id = cuenta().ToString();
                documento.Load(@"BD\Equipos.xml");
                
                
                //C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml
                //documento.Load(@"C:\Program Files\HB CONSULTING\GEOTON-UVM\BD\Equipos.xml");

                //documento.Load("C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml");

                XmlNode equipo = documento.CreateElement("equipo");

                XmlElement idEquipo = documento.CreateElement("idEquipo");
                idEquipo.InnerText = id;
                equipo.AppendChild(idEquipo);

                XmlElement nombre = documento.CreateElement("nombre");
                nombre.InnerText = name;
                equipo.AppendChild(nombre);

                XmlElement apellidos = documento.CreateElement("puntaje");
                apellidos.InnerText = "0";
                equipo.AppendChild(apellidos);

                XmlNode nodoRaiz = documento.DocumentElement;

                nodoRaiz.InsertAfter(equipo, nodoRaiz.LastChild);   //***

                documento.Save(@"BD\Equipos.xml");
                //documento.Save("C:\\Program Files (x86)\\HB CONSULTING\\GEOTON-UVM\\BD\\Equipos.xml");

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
            //documento.Save(@"C:\Program Files\HB CONSULTING\GEOTON-UVM\BD\Equipos.xml");
           
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void puntaje()
        {
            //Cargamos el documento XML.
            
            documento.Load(@"BD\Equipos.xml");

            //Obtenemos el nodo raiz del documento.
            XmlElement equipos = documento.DocumentElement;

            //Obtenemos la lista de todos los empleados.
            XmlNodeList listaEquipos= documento.SelectNodes("equipos/equipo");

            foreach (XmlNode item in listaEquipos)
            {
                //Determinamos el nodo a modificar por medio del id de empleado.
                if (item.FirstChild.InnerText == "2")
                {
                    string id = item["idEquipo"].InnerText;
                    string nombre = item["nombre"].InnerText;
                    string puntaje = "34";
                    XmlNode nodoOld = item;

                    //Nodo nuevo.
                    XmlNode nodoNew = CrearNodoXml(id, nombre,puntaje);

                    //Remplazamos el nodo.
                    equipos.ReplaceChild(nodoNew, nodoOld);
                }
            }
            documento.Save(@"BD\Equipos.xml");
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void puntaje_agrega(string gana)
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == gana)
                {
                    string id = item["idEquipo"].InnerText;
                    string nombre = item["nombre"].InnerText;
                    int new_puntaje = int.Parse(item["puntaje"].InnerText) +1;
                    string puntaje = new_puntaje.ToString();
                    XmlNode nodoOld = item;
                    XmlNode nodoNew = CrearNodoXml(id, nombre, puntaje);
                    equipos.ReplaceChild(nodoNew, nodoOld);
                }
            }
            documento.Save(@"BD\Equipos.xml");
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"BD\Equipos.xml")]
        public void reset_puntaje()
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            foreach (XmlNode item in listaEquipos)
            {                           
                string id = item["idEquipo"].InnerText;
                string nombre = item["nombre"].InnerText;
                string puntaje = "0";
                XmlNode nodoOld = item;
                XmlNode nodoNew = CrearNodoXml(id, nombre, puntaje);
                equipos.ReplaceChild(nodoNew, nodoOld);                
            }
            documento.Save(@"BD\Equipos.xml");
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void eliminar(string id)
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == id)
                {                    
                    XmlNode nodoOld = item;
                    equipos.RemoveChild(nodoOld);
                }
            }
            documento.Save(@"BD\Equipos.xml");
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void elimina_todo()
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");

            foreach (XmlNode item in listaEquipos)
            {
                    XmlNode nodoOld = item;;
                    equipos.RemoveChild(nodoOld);
            }
            documento.Save(@"BD\Equipos.xml");
        }

        //[PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]

        public int cuenta()
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            int cuantos  = listaEquipos.Count;
            return cuantos+1;
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void reacomodo()
        {
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            int new_id = 0;
            foreach (XmlNode item in listaEquipos)
            {
                new_id = new_id + 1;
                string id = new_id.ToString();
                    string nombre = item["nombre"].InnerText;
                    string puntaje = item["puntaje"].InnerText;//"34";
                    XmlNode nodoOld = item;
                    XmlNode nodoNew = CrearNodoXml(id, nombre, puntaje);
                    equipos.ReplaceChild(nodoNew, nodoOld);
            }
            documento.Save(@"BD\Equipos.xml");
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\")]
        public void mueve_arriba(string este)
        {
            int id_arriba = int.Parse(este) - 1;
            string new_name_abajo=null;
            string new_puntaje_abajo = null;

            string new_name_arriba = null;
            string new_puntaje_arriba = null;

            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            //int new_id = 0;

            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == id_arriba.ToString())
                {                   
                    new_name_abajo = item["nombre"].InnerText;
                    new_puntaje_abajo = item["puntaje"].InnerText;//"34";                    
                }

                if (item.FirstChild.InnerText == este)
                {
                    new_name_arriba = item["nombre"].InnerText;
                    new_puntaje_arriba = item["puntaje"].InnerText;//"34";                    
                }
            }

            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == id_arriba.ToString())
                {                    
                    string id = item["idEquipo"].InnerText;
                    string nombre = new_name_arriba;
                    string puntaje = new_puntaje_arriba;
                    XmlNode nodoOld = item;
                    XmlNode nodoNew = CrearNodoXml(id, nombre, puntaje);
                    equipos.ReplaceChild(nodoNew, nodoOld);
                }
                if (item.FirstChild.InnerText == este)
                {
                    string id = item["idEquipo"].InnerText;
                    string nombre = new_name_abajo;
                    string puntaje = new_puntaje_abajo;
                    XmlNode nodoOld = item;
                    XmlNode nodoNew = CrearNodoXml(id, nombre, puntaje);
                    equipos.ReplaceChild(nodoNew, nodoOld);
                }
            }
            documento.Save(@"BD\Equipos.xml");
        }


        public string dime_equipo(string id)
        {
            string nombre_equipo = null;
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            //int new_id = 0;

            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == id)
                {
                    nombre_equipo = item["nombre"].InnerText;
                                      
                }
            }

            return nombre_equipo;
        }

        public string dime_puntaje(string id)
        {
            string puntaje = null;
            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            foreach (XmlNode item in listaEquipos)
            {
                if (item.FirstChild.InnerText == id)
                {
                    puntaje = item["puntaje"].InnerText;

                }
            }
            return puntaje;
        }


        public int[] lugares()
        {
            int[] lugares = new int[3];
            int primero=-1;
            int segundo = -1;
            int tercero = -1;

            int id_primero=0;
            int id_segundo=0;
            int id_tecero=0;

            documento.Load(@"BD\Equipos.xml");
            XmlElement equipos = documento.DocumentElement;
            XmlNodeList listaEquipos = documento.SelectNodes("equipos/equipo");
            foreach (XmlNode item in listaEquipos)
            {
                int tem = int.Parse(item["puntaje"].InnerText);
                if (tem > primero)
                {
                    id_primero = int.Parse(item["idEquipo"].InnerText);
                    primero = int.Parse(item["puntaje"].InnerText);                    
                }
            }

            foreach (XmlNode item in listaEquipos)
            {
                int tem = int.Parse(item["puntaje"].InnerText);
                if (tem > segundo)
                {
                    int id_aux = id_segundo;
                    int puntaje_aux = segundo;

                    id_segundo = int.Parse(item["idEquipo"].InnerText);
                    segundo = int.Parse(item["puntaje"].InnerText); 
                    if (id_segundo  == id_primero)
                    {
                        id_segundo = id_aux;
                        segundo = puntaje_aux;
                    }                                        
                }
            }
                        
            foreach (XmlNode item in listaEquipos)
            {
                int tem = int.Parse(item["puntaje"].InnerText);
                if (tem > tercero)
                {
                    int id_aux = id_tecero;
                    int puntaje_aux = tercero;

                    id_tecero = int.Parse(item["idEquipo"].InnerText);
                    tercero = int.Parse(item["puntaje"].InnerText); 
                    if (id_tecero  == id_primero || id_tecero == id_segundo)
                    {
                        id_tecero= id_aux;
                        tercero = puntaje_aux;
                    }                                        
                }
            }

            lugares[0] = id_primero;
            lugares[1] = id_segundo;
            lugares[2] = id_tecero;


            return lugares;
        }


        private XmlNode CrearNodoXml(string id, string nom, string puntaje)
        {
            //Creamos el nodo que deseamos insertar.
            //XmlElement empleado = documento.CreateElement("equipo");

            XmlNode equipo = documento.CreateElement("equipo");

            //Creamos el elemento idEmpleado.
            XmlElement idEquipo = documento.CreateElement("idEquipo");
            idEquipo.InnerText = id;
            equipo.AppendChild(idEquipo);

            //Creamos el elemento nombre.
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = nom;
            equipo.AppendChild(nombre);

            //Creamos el elemento apellidos.
            XmlElement apellidos = documento.CreateElement("puntaje");
            apellidos.InnerText = puntaje;
            equipo.AppendChild(apellidos);


            return equipo;
        }


        private void abre_base()
        {

            //esto lo cambiare para hacerlo en linea por eso es facil

            try
            {
                ////creamos la Instancia
                //conexionn = new SqlConnection();
                ////Relizamos la coneccion
                ////conexionn.ConnectionString = @"Server = MCP_EDGAR\SQLEXPRESS; Database = Credi_seg; Trusted_Connection = True";
                //conexionn.ConnectionString = @"Data source='C:\Users\edgar\Desktop\GEOTON_final_II\Geoton\Geoton\Geoton\Paises.sdf'";
                //conexionn.Open();


                //Indicamos el origen de datos
               // SqlCeEngine objEg = new SqlCeEngine("Data Source=\\Paises.SDF");
                //SqlCeConnection objCon = new SqlCeConnection(@"Data Source=Paises.SDF");
                //objCon.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido ingresar a la base de datos por favor comuniquese con edgar_he4@hotmail.com");
            }
        }


    }
}
