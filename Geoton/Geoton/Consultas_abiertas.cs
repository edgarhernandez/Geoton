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
    class Consultas_abiertas
    {
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

        public string pregunta_abierta(int id_pregunta)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\abiertas.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT PREGUNTA FROM [abiertas$] WHERE ID_PREGUNTA = " + id_pregunta;
            conexion.Open();
            string pregunta = null;
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                pregunta = dr["PREGUNTA"].ToString();
            }
            conexion.Close();
            return pregunta;
        }

        public string respuesta_abierta(int id_pregunta)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD\abiertas.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            DbConnection conexion = factory.CreateConnection();
            DbCommand comando = conexion.CreateCommand();
            conexion.ConnectionString = connectionString;
            comando.CommandText = "SELECT RESPUESTA FROM [abiertas$] WHERE ID_PREGUNTA = " + id_pregunta;
            conexion.Open();
            string pregunta = null;
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                pregunta = dr["RESPUESTA"].ToString();
            }
            conexion.Close();
            return pregunta;
        }

    }
}
