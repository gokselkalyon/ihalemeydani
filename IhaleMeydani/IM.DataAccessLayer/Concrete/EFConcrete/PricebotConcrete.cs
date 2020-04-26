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
    public class PricebotConcrete : BaseConcrete, IDataAccessDal<PRICEBOT>
    {
        public void Add(PRICEBOT entity)
        {
            DB.PRICEBOTs.Add(entity);
            DB.SaveChanges();
        }

        public PRICEBOT Get(int id)
        {
            return DB.PRICEBOTs.Find(id);
        }

        public List<PRICEBOT> GetAll()
        {
            return DB.PRICEBOTs.ToList();
        }

        public IEnumerable<PRICEBOT> GetFilter(Expression<Func<PRICEBOT, bool>> expression)
        {
            return DB.PRICEBOTs.Where(expression);
        }

        public void Remove(int id)
        {
            DB.PRICEBOTs.Remove(DB.PRICEBOTs.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(PRICEBOT t)
        {
            DB.PRICEBOTs.Remove(t);
            DB.SaveChanges();
        }

        public void Update(PRICEBOT t)
        {
            DB.PRICEBOTs.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
