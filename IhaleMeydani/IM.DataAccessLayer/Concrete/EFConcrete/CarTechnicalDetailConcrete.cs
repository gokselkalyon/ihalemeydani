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
    public class CarTechnicalDetailConcrete : BaseConcrete, IDataAccessDal<CarTechnicalDetail>
    {
        public void Add(CarTechnicalDetail entity)
        {
            DB.CarTechnicalDetails.Add(entity);
            DB.SaveChanges();
        }

        public CarTechnicalDetail Get(int id)
        {
            return DB.CarTechnicalDetails.Find(id);
        }

        public List<CarTechnicalDetail> GetAll()
        {
            return DB.CarTechnicalDetails.ToList();
        }

        public IEnumerable<CarTechnicalDetail> GetFilter(Expression<Func<CarTechnicalDetail, bool>> expression)
        {
            return DB.CarTechnicalDetails.Where(expression);
        }

        public void Remove(int id)
        {
            DB.CarTechnicalDetails.Remove(DB.CarTechnicalDetails.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CarTechnicalDetail t)
        {
            DB.CarTechnicalDetails.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CarTechnicalDetail t)
        {
            DB.CarTechnicalDetails.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
