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
    
    public partial class Prenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prenda()
        {
            this.NotaPrenda = new HashSet<NotaPrenda>();
        }
    
        public int id { get; set; }
        public int idTipoPrenda { get; set; }
        public int idArreglo { get; set; }
        public decimal Cantidad { get; set; }
    
        public virtual Arreglo Arreglo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaPrenda> NotaPrenda { get; set; }
        public virtual TipoPrenda TipoPrenda { get; set; }
    }
}
