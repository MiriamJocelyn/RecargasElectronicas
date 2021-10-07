﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace El_Hivan.Models
{
    public class queryNotaP
    {
        private ElHilvanEntities db = new ElHilvanEntities();
        public void Update(int idNota)
        {
            var data = (from n in db.NotaPrenda
                        where n.idNota == null
                        select n).ToList();

            for (int i = 0; i < data.Count(); i++)
            {
                data[i].idNota = idNota;
                db.Entry(data[i]).State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }

    }
}