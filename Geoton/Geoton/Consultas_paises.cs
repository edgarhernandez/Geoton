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

namespace Geoton
{
    class Consultas_paises
    {
        public SqlConnection conexionn;


        public int cuenta_paises()
        {
            //abre_base();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            // se instancia la conexion             
            DbConnection conexion = factory.CreateConnection();
            // se instancia el comando 
            DbCommand comando = conexion.CreateCommand();
            // se asigna el string con la conexion 
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT COUNT(ID_PAIS) as n_pais FROM [paises$]";
            conexion.Open();
            DbDataReader dr = comando.ExecuteReader();
             int pa = 0; 
            try
            {                                        
                while (dr.Read())
                {
                    pa = int.Parse(dr["n_pais"].ToString());
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
            }            
            conexion.Close();
            return pa;
        }

        public int cuenta_abiertos()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\abiertas.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");          
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT COUNT(ID_PREGUNTA) as n_preguntas FROM [abiertas$]";
            conexion.Open();
            DbDataReader dr = comando.ExecuteReader();
            int pa = 0;
            try
            {
                while (dr.Read())
                {
                    pa = int.Parse(dr["n_preguntas"].ToString());
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString());
            }
            conexion.Close();
            return pa;
        }

        public string pais_pregunta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT PAIS FROM [paises$] WHERE ID_PAIS = " + id_pais ;
            conexion.Open();
            string pregunta = null;
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                pregunta = dr["PAIS"].ToString();
            }
            conexion.Close();
            return pregunta;
        }

        public string capital_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT CAPITAL FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();                

            while (dr.Read())
            {
                respuesta = dr["CAPITAL"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public string continente_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT CONTINENTE FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;            
            DbDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                respuesta = dr["CONTINENTE"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public string idioma_oficial_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT IDIOMA FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();
            
            while (dr.Read())
            {
                respuesta = dr["IDIOMA"].ToString();
            }            
            conexion.Close();
            return respuesta;
        }

        public string moneda_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT MONEDA FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                respuesta = dr["MONEDA"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public string gobierno_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");           
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT GOBIERNO FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();          
            while (dr.Read())
            {
                respuesta = dr["GOBIERNO"].ToString();
            }     
            conexion.Close();
            return respuesta;
        }

        public string gentilicio_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT GENTILICIOS FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                respuesta = dr["GENTILICIOS"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public string nombre_oficial_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT NOMBRE_OFICIAL FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();
            string respuesta = null;
            DbDataReader dr = comando.ExecuteReader();            
            while (dr.Read())
            {
                respuesta = dr["NOMBRE_OFICIAL"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public string bandera_respuesta(int id_pais)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\pais.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT BANDERA FROM [paises$] WHERE ID_PAIS = " + id_pais;
            conexion.Open();           
            DbDataReader dr = comando.ExecuteReader();
             string respuesta = null;
            while (dr.Read())
            {
                respuesta = dr["BANDERA"].ToString();
            }
            conexion.Close();
            return respuesta;
        }

        public DataTable n_paises()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\paises.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";

            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;

            comando.CommandText = "SELECT COUNT(ID_PAIS) as n_pais FROM [paises$]";
            conexion.Open();

            DbDataReader dr = comando.ExecuteReader();

            DataTable dt = dr.GetSchemaTable();
            //dt.Columns[
            conexion.Close();
            return dt;
        }


        private void abre_base()
        {

            //esto lo cambiare para hacerlo en linea por eso es facil

            try
            {
                //creamos la Instancia
                conexionn = new SqlConnection();
                //Relizamos la coneccion
                //conexionn.ConnectionString = @"Server = MCP_EDGAR\SQLEXPRESS; Database = Credi_seg; Trusted_Connection = True";
                conexionn.ConnectionString = "Server = ./SqlExpress;Database =Paises;Integrated Security = SSPI;" ;
                conexionn.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido ingresar a la base de datos por favor comuniquese con edgar_he4@hotmail.com");
            }
        }
    }
}
