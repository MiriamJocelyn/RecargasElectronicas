using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contactos.Models
{
    public class Tablas
    {
        public class Contacto {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int IdTipoContacto { get; set; }
            public string TelefonoFijo { get; set; }
            public string TelefonoMovil { get; set; }
            [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
            public DateTime FechaNacimiento { get; set; }
            public int IdSexo { get; set; }
            public int IdEstadoCivil { get; set; }
        }
        public class ContactoBusqueda
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string TipoContacto { get; set; }
            public string TelefonoFijo { get; set; }
            public string TelefonoMovil { get; set; }
            public string FechaNacimiento { get; set; }
            public string Sexo { get; set; }
            public string EstadoCivil { get; set; }
        }
        public class TablasForaneas
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
       
    }
}