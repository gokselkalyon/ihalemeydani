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
    public class CarBrandConcrete : BaseConcrete, IDataAccessDal<CarBrand>
    {
        public void Add(CarBrand entity)
        {
            DB.CarBrands.Add(entity);
            DB.SaveChanges();
        }

        public CarBrand Get(int id)
        {
            return DB.CarBrands.Find(id);
        }

        public List<CarBrand> GetAll()
        {
            return DB.CarBrands.ToList();
        }

        public IEnumerable<CarBrand> GetFilter(Expression<Func<CarBrand, bool>> expression)
        {
            return DB.CarBrands.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Users.Remove(DB.Users.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CarBrand t)
        {
            DB.CarBrands.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CarBrand t)
        {
            DB.CarBrands.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
