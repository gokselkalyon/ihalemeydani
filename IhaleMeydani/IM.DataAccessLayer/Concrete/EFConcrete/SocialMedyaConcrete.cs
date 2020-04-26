using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class SocialMedyaConcrete : BaseConcrete, IDataAccessDal<SocialMedya>
    {
        public void Add(SocialMedya entity)
        {
            DB.SocialMedyas.Add(entity);
            DB.SaveChanges();
        }

        public SocialMedya Get(int id)
        {
            return DB.SocialMedyas.Find(id);
        }

        public List<SocialMedya> GetAll()
        {
            return DB.SocialMedyas.ToList();
        }

        public IEnumerable<SocialMedya> GetFilter(Expression<Func<SocialMedya, bool>> expression)
        {
            return DB.SocialMedyas.Where(expression);
        }

        public void Remove(int id)
        {
            DB.SocialMedyas.Remove(DB.SocialMedyas.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(SocialMedya t)
        {
            DB.SocialMedyas.Remove(t);
            DB.SaveChanges();
        }

        public void Update(SocialMedya t)
        {
            DB.SocialMedyas.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
