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
    public class GeneralDesignConcrete : BaseConcrete, IDataAccessDal<GeneralDesign>
    {
        public void Add(GeneralDesign entity)
        {
            DB.GeneralDesigns.Add(entity);
            DB.SaveChanges();
        }

        public GeneralDesign Get(int id)
        {
            return DB.GeneralDesigns.Find(id);
        }

        public List<GeneralDesign> GetAll()
        {
            return DB.GeneralDesigns.ToList();
        }

        public IEnumerable<GeneralDesign> GetFilter(Expression<Func<GeneralDesign, bool>> expression)
        {
            return DB.GeneralDesigns.Where(expression);
        }

        public void Remove(int id)
        {
            DB.GeneralDesigns.Remove(DB.GeneralDesigns.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(GeneralDesign t)
        {
            DB.GeneralDesigns.Remove(t);
            DB.SaveChanges();
        }

        public void Update(GeneralDesign t)
        {
            DB.GeneralDesigns.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
