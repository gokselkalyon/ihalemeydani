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
    public class IconConcrete : BaseConcrete, IDataAccessDal<Icon>
    {
        public void Add(Icon entity)
        {
            DB.Icons.Add(entity);
            DB.SaveChanges();
        }

        public Icon Get(int id)
        {
            return DB.Icons.Find(id);
        }

        public List<Icon> GetAll()
        {
            return DB.Icons.ToList();
        }

        public IEnumerable<Icon> GetFilter(Expression<Func<Icon, bool>> expression)
        {
            return DB.Icons.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Icons.Remove(DB.Icons.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Icon t)
        {
            DB.Icons.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Icon t)
        {
            DB.Icons.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
