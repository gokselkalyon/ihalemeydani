using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class LogManager : IDataBusinessService<log>
    {
        private IDataAccessDal<log> _dataAccessDal;
        public LogManager(IDataAccessDal<log> dataAccessDal)
        {
            _dataAccessDal = dataAccessDal;
        }
        public void Add(log entity)
        {
            _dataAccessDal.Add(entity);
        }

        public log Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<log> GetAll()
        {
            return _dataAccessDal.GetAll();
        }

        public IEnumerable<log> GetFilter(Expression<Func<log, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(log t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(log t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
