using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace El_Hivan.Models
{
    public class queryNota
    {
        private ElHilvanEntities db = new ElHilvanEntities();
        public int Folio ()
        {
            var data = (from n in db.Nota
                        select n).ToList();
            return data.Count()+1;
        }

        public int IdNota()
        {
            var data = (from n in db.Nota
                        select n).OrderByDescending(n => n.id).FirstOrDefault();

            return data.id;
        }
    }
}