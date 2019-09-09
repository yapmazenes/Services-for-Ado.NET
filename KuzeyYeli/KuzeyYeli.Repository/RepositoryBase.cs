using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    using Entity.Models;
    public class RepositoryBase<TT> : IRepository<TT> where TT : class
    {
        private static NorthwindEntities Db;
        //Singleton Pattern: Uygulamanın tek context veya tek connection üzerinden işlem yapmasının sağlandığı tasarım desenidir.
        public static NorthwindEntities db
        {
            get
            {
                Db = Db ?? new NorthwindEntities();
                return Db;
            }
            set { Db = value; }
        }

        public List<TT> Listele()
        {
            return db.Set<TT>().ToList();
        }

        public bool Ekle(TT entity)
        {

            db.Set<TT>().Add(entity);
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool Guncelle(TT entity)
        {
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;

                
            }
        }

        public bool Sil(TT entity)
        {
            db.Set<TT>().Remove(entity);
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
                
               
            }
        }
    }
}
