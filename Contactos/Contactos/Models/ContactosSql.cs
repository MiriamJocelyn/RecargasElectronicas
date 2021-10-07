using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Contactos.Models.Tablas;

namespace Contactos.Models
{
    public class ContactosSql : IContactoIn
    {
        private string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\dbExamen.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        
        public Contacto Busquedas(int id)
        {

            Contacto contacto = new Contacto();

            string query = "EXEC [dbo].[ListContactosXId] @IdContacto ="+id;
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


                    contacto.Id = Convert.ToInt32(reader["Id"]);
                    contacto.Nombre = Convert.ToString(reader["Nombre"]);
                    contacto.IdTipoContacto = Convert.ToInt32(reader["IdTipoContacto"]);
                    contacto.TelefonoFijo = Convert.ToString(reader["TelefonoFijo"]);
                    contacto.TelefonoMovil = Convert.ToString(reader["TelefonoMovil"]);
                    contacto.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                    contacto.IdSexo = Convert.ToInt32(reader["IdSexo"]);
                    contacto.IdEstadoCivil = Convert.ToInt32(reader["IdEstadoCivil"]);
                }

                reader.Close();
            }

            cnn.Close();
            return contacto;
        }

        public List<ContactoBusqueda> GetAll()
        {
            List<ContactoBusqueda> contactos = new List<ContactoBusqueda>();

            string query = "EXEC [dbo].[ListContactosAll]";
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
                    contactos.Add(new ContactoBusqueda {Id=Convert.ToInt32(reader["Id"]), Nombre = Convert.ToString(reader["Nombre"]),TipoContacto = Convert.ToString(reader["TipoContacto"]),
                    TelefonoFijo=Convert.ToString(reader["TelefonoFijo"]),
                    TelefonoMovil = Convert.ToString(reader["TelefonoMovil"]),
                     FechaNacimiento = Convert.ToString(reader["FechaNacimiento"]),
                     Sexo= Convert.ToString(reader["Sexo"]),
                     EstadoCivil=Convert.ToString(reader["EstadoCivil"])
                    });
                }

                reader.Close();
            }

            cnn.Close();
            return contactos;
        }

        public bool Save(Contacto c)
        {
            try
            {
                string query = "Insert Into dbo.ContactosMAVIMiriam(Nombre,IdTipoContacto,TelefonoFijo,TelefonoMovil,FechaNacimiento,IdSexo,IdEstadoCivil) Values(@Nombre,@IdTipoContacto,@TelefonoFijo,@TelefonoMovil,@FechaNacimiento,@IdSexo,@IdEstadoCivil)";
                Conexion conexion = new Conexion();
                SqlConnection cnn = conexion.ObtConexion(connectionString);
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@Nombre", c.Nombre);
                    command.Parameters.AddWithValue("@IdTipoContacto", c.IdTipoContacto);
                    command.Parameters.AddWithValue("@TelefonoFijo", c.TelefonoFijo);
                    command.Parameters.AddWithValue("@TelefonoMovil", c.TelefonoMovil);
                    command.Parameters.AddWithValue("@FechaNacimiento", c.FechaNacimiento);
                    command.Parameters.AddWithValue("@IdSexo", c.IdSexo);
                    command.Parameters.AddWithValue("@IdEstadoCivil", c.IdEstadoCivil);
                    cnn.Open();
                    command.ExecuteNonQuery();
                }
                cnn.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public List<Contacto> Search(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Contacto c)
        {
            try
            {
                string query = "Update dbo.ContactosMAVIMiriam " +
                    "set Nombre = \'" + c.Nombre +"\'"+
                    "IdTipoContacto=\'"+c.IdTipoContacto+"\'"+
                    "TelefonoFijo=\'"+c.TelefonoFijo+"\'"+
                    "FechaNacimiento=\'" + c.FechaNacimiento + "\'" +
                    "IdSexo=\'" + c.IdSexo + "\'" +
                    "IdEstadoCivil=\'" + c.IdEstadoCivil + "\'" +
                    "where Id=" + c.Id;
                Conexion conexion = new Conexion();
                SqlConnection cnn = conexion.ObtConexion(connectionString);
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                   
                    cnn.Open();
                    command.ExecuteNonQuery();
                }
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