//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace El_Hivan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotaPrenda
    {
        public int id { get; set; }
        public Nullable<int> idNota { get; set; }
        public int idPrenda { get; set; }
        public string Descripcion { get; set; }
        public int CantidadPrendas { get; set; }
    
        public virtual Nota Nota { get; set; }
        public virtual Prenda Prenda { get; set; }
    }
}
