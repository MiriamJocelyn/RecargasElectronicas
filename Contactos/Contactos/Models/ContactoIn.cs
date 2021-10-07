using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Contactos.Models.Tablas;

namespace Contactos.Models
{
    public interface IContactoIn
    {
        bool Save(Contacto c);
        List<ContactoBusqueda> GetAll();
        List<Contacto> Search(string nombre);
        bool Delete(int id);
        bool Edit(Contacto c);
        Contacto Busquedas(int id);

    }
}
