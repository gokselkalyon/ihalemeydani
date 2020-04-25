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
    public class CarDetailConcrete : BaseConcrete, IDataAccessDal<CarDetail>
    {
        public void Add(CarDetail entity)
        {
            DB.CarDetails.Add(entity);
            DB.SaveChanges();
        }

        public CarDetail Get(int id)
        {
            return DB.CarDetails.Find(id);
        }

        public List<CarDetail> GetAll()
        {
            return DB.CarDetails.ToList();
        }

        public IEnumerable<CarDetail> GetFilter(Expression<Func<CarDetail, bool>> expression)
        {
            return DB.CarDetails.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Users.Remove(DB.Users.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CarDetail t)
        {
            DB.CarDetails.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CarDetail t)
        {
            DB.CarDetails.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
