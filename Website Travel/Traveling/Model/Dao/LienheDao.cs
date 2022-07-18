using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class LienheDao
    {
        MyDB db = new MyDB();
        //public long Insert(LienHe lienHe)
        //{
        //    db.LienHes.Add(lienHe);
        //    db.SaveChanges();
        //    return lienHe.ID;
        //}
        public List<LienHe> GetList()
        {
            List<LienHe> list = new List<LienHe>();
            list = db.LienHes.ToList();
            return list;
        }
    }
    }
