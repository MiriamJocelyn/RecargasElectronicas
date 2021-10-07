using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Contactos.Models.Tablas;

namespace Contactos.Models
{
    public class SexoSql : ITablaForanea
    {
        private string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\dbExamen.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public List<TablasForaneas> GetAll()
        {
            List<TablasForaneas> Sexo = new List<TablasForaneas>();

            string query = "EXEC [dbo].[ListSexo]";
            Conexion conexion = new Conexion();
            SqlConnection cnn = conexion.ObtConexion(connectionString);
            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                cnn.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                var dynamic = reader;
                while (reader.Read())
                {
                    Sexo.Add(new TablasForaneas { Id = Convert.ToInt32(reader["Id"]), Nombre = Convert.ToString(reader["Nombre"]) });
                }
                
                reader.Close();
            }
            
            cnn.Close();
            return Sexo;
        }

        public bool Save(TablasForaneas t)
        {
            try
            {
                string query = "Insert Into dbo.Sexo (Nombre) Values(@Nombre)";
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
            catch
            {
                return false;
            }
        }
    }
}