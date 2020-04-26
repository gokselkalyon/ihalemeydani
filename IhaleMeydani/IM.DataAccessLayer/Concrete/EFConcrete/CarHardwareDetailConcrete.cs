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
    public class CarHardwareDetailConcrete : BaseConcrete, IDataAccessDal<CarHardwareDetail>
    {
        public void Add(CarHardwareDetail entity)
        {
            DB.CarHardwareDetails.Add(entity);
            DB.SaveChanges();
        }

        public CarHardwareDetail Get(int id)
        {
            return DB.CarHardwareDetails.Find(id);
        }

        public List<CarHardwareDetail> GetAll()
        {
            return DB.CarHardwareDetails.ToList();
        }

        public IEnumerable<CarHardwareDetail> GetFilter(Expression<Func<CarHardwareDetail, bool>> expression)
        {
            return DB.CarHardwareDetails.Where(expression);
        }

        public void Remove(int id)
        {
            DB.CarHardwareDetails.Remove(DB.CarHardwareDetails.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CarHardwareDetail t)
        {
            DB.CarHardwareDetails.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CarHardwareDetail t)
        {
            DB.CarHardwareDetails.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
