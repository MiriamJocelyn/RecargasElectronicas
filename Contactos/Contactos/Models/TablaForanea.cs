using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Contactos.Models.Tablas;

namespace Contactos.Models
{
    public interface ITablaForanea
    {
        List<TablasForaneas> GetAll();
        bool Save(TablasForaneas t);

    }
}
