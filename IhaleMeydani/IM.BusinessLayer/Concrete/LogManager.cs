using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using Microsoft.Win32.SafeHandles;
using System;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class LogManager : IDataBusinessService<log>
    {
        private IDataAccessDal<log> _dataAccessDal;
        private readonly IMapper _mapper;

        public LogManager(IDataAccessDal<log> dataAccessDal,IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
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
            var _log = _mapper.Map<List<log>>(_dataAccessDal.GetAll());
            //var _log = AutoMapperHelper.MapToSameTypeList(_dataAccessDal.GetAll());
            return _log;
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

        
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }
    }
}
