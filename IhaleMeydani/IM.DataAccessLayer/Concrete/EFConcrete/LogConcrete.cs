﻿using IM.DataAccessLayer.Abstract;
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
    public class LogConcrete : BaseConcrete, IDataAccessDal<Log>
    {
        public void Add(Log entity)
        {
            DB.Logs.Add(entity);
            DB.SaveChanges();
        }

        public Log Get(int id)
        {
            return DB.Logs.Find(id);
        }

        public List<Log> GetAll()
        {
            return DB.Logs.ToList();
        }

        public IEnumerable<Log> GetFilter(Expression<Func<Log, bool>> expression)
        {
            return DB.Logs.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Logs.Remove(DB.Logs.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Log t)
        {
            DB.Logs.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Log t)
        {
            DB.Logs.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
