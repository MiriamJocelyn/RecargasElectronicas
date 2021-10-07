using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Contactos.Models.Tablas;
using System.Data.SqlTypes;

namespace Contactos.Models
{
    public class TipoContactoSql : ITablaForanea
    {
        private string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\dbExamen.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public List<TablasForaneas> GetAll()
        {

            //agregar try catch
            List<TablasForaneas> TipoContacto = new List<TablasForaneas>();

            string query = "EXEC [dbo].[ListTipoContacto]";
            Conexion conexion = new Conexion();
            SqlConnection cnn = conexion.ObtConexion(connectionString);

           
            
            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                
                cnn.Open();
                
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                    {
                    TipoContacto.Add(new TablasForaneas { Id = Convert.ToInt32(reader["Id"]), Nombre = Convert.ToString(reader["Nombre"]) });

                }
                //TipoContacto.Add(new TablasForaneas { Id = Convert.ToInt32(reader["Id"]), Nombre = Convert.ToString(reader["Nombre"]) });
                reader.Close();
            }
         
            cnn.Close();
            return TipoContacto;
        }

        public bool Save(TablasForaneas t)
        {
            try
            {
                string query = "Insert Into dbo.TipoContacto (Nombre) Values(@Nombre)";
                Conexion conexion = new Conexion();
                SqlConnection cnn = conexion.ObtConexion(connectionString);
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@Nombre", t.Nombre);
                    cnn.Open();
                    command.ExecuteNonQuery();
                }
                cnn.Close();
                return true;
            }
            catch {
                return false;

            }
        }


    }
}