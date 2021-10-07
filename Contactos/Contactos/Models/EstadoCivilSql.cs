using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Contactos.Models.Tablas;

namespace Contactos.Models
{
    public class EstadoCivilSql : ITablaForanea
    {
        private string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\dbExamen.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        public List<Tablas.TablasForaneas> GetAll()
        {
            List<TablasForaneas> EstadoCivil = new List<TablasForaneas>();

            string query = "EXEC [dbo].[ListEstadoCivil]";
            Conexion conexion = new Conexion();
            SqlConnection cnn = conexion.ObtConexion(connectionString);
            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                cnn.Open();
                //command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EstadoCivil.Add(new TablasForaneas { Id = Convert.ToInt32(reader["Id"]), Nombre = Convert.ToString(reader["Nombre"]) });
                }

                reader.Close();
            }
            cnn.Close();
            return EstadoCivil;
        }

        public bool Save(Tablas.TablasForaneas t)
        {
            try
            {
                string query = "Insert Into dbo.EstadoCivil (Nombre) Values(@Nombre)";
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