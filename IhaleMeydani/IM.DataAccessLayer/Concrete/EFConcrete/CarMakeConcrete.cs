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
    public class CarMakeConcrete : BaseConcrete, IDataAccessDal<CarMake>
    {
        public void Add(CarMake entity)
        {
            DB.CarMakes.Add(entity);
            DB.SaveChanges();
        }

        public CarMake Get(int id)
        {
            return DB.CarMakes.Find(id);
        }

        public List<CarMake> GetAll()
        {
            return DB.CarMakes.ToList();
        }

        public IEnumerable<CarMake> GetFilter(Expression<Func<CarMake, bool>> expression)
        {
            return DB.CarMakes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.CarMakes.Remove(DB.CarMakes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CarMake t)
        {
            DB.CarMakes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CarMake t)
        {
            DB.CarMakes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
