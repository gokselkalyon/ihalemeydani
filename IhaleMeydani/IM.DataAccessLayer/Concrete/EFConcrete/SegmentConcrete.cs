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
    public class SegmentConcrete : BaseConcrete, IDataAccessDal<Segment>
    {
        public void Add(Segment entity)
        {
            DB.Segments.Add(entity);
            DB.SaveChanges();
        }

        public Segment Get(int id)
        {
            return DB.Segments.Find(id);
        }

        public List<Segment> GetAll()
        {
            return DB.Segments.ToList();
        }

        public IEnumerable<Segment> GetFilter(Expression<Func<Segment, bool>> expression)
        {
            return DB.Segments.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Segments.Remove(DB.Segments.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Segment t)
        {
            DB.Segments.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Segment t)
        {
            DB.Segments.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
