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
    public class GearTypeConcrete : BaseConcrete, IDataAccessDal<GearType>
    {
        public void Add(GearType entity)
        {
            DB.GearTypes.Add(entity);
            DB.SaveChanges();
        }

        public GearType Get(int id)
        {
            return DB.GearTypes.Find(id);
        }

        public List<GearType> GetAll()
        {
            return DB.GearTypes.ToList();
        }

        public IEnumerable<GearType> GetFilter(Expression<Func<GearType, bool>> expression)
        {
            return DB.GearTypes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.GearTypes.Remove(DB.GearTypes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(GearType t)
        {
            DB.GearTypes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(GearType t)
        {
            DB.GearTypes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
