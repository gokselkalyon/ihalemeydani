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
    public class FuelTypeConcrete : BaseConcrete, IDataAccessDal<FuelType>
    {
        public void Add(FuelType entity)
        {
            DB.FuelTypes.Add(entity);
            DB.SaveChanges();
        }

        public FuelType Get(int id)
        {
            return DB.FuelTypes.Find(id);
        }

        public List<FuelType> GetAll()
        {
            return DB.FuelTypes.ToList();
        }

        public IEnumerable<FuelType> GetFilter(Expression<Func<FuelType, bool>> expression)
        {
            return DB.FuelTypes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.FuelTypes.Remove(DB.FuelTypes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(FuelType t)
        {
            DB.FuelTypes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(FuelType t)
        {
            DB.FuelTypes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
