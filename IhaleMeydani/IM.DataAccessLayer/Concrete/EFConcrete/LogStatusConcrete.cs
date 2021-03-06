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
    public class LogStatusConcrete:BaseConcrete, IDataAccessDal<LogStatus>
    {
        public void Add(LogStatus entity)
        {
            DB.LogStatus1.Add(entity);
            DB.SaveChanges();
        }

        public LogStatus Get(int id)
        {
            return DB.LogStatus1.Find(id);
        }

        public List<LogStatus> GetAll()
        {
            return DB.LogStatus1.ToList();
        }

        public IEnumerable<LogStatus> GetFilter(Expression<Func<LogStatus, bool>> expression)
        {
            return DB.LogStatus1.Where(expression);
        }

        public void Remove(int id)
        {
            DB.LogStatus1.Remove(DB.LogStatus1.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(LogStatus t)
        {
            DB.LogStatus1.Remove(t);
            DB.SaveChanges();
        }

        public void Update(LogStatus t)
        {
            DB.LogStatus1.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
