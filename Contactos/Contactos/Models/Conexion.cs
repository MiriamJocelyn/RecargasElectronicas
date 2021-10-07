using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Contactos.Models
{
    public class Conexion
    {
        public SqlConnection ObtConexion(string connectionString) {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            return cnn;
        }

        //public bool AddSQL(string query,string connectionString, dynamic t)
        //{
        //    Conexion conexion = new Conexion();
        //    SqlConnection cnn;
        //    cnn = new SqlConnection(connectionString);
          
        //    using (SqlCommand command = new SqlCommand(query, cnn))
        //    {
        //        command.Parameters.AddWithValue("@Nombre", t.Nombre);
        //        cnn.Open();
        //        command.ExecuteNonQuery();
        //    }

        //}


        public bool Open(string connectionString) {
            try
            {
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                return true;
            }

            catch (Exception e)
            {
                return false;

            }
        }
        public bool Close(string connectionString) {
            try
            {
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
         }
    }
}