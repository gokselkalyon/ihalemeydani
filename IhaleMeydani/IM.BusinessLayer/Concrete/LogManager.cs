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
    public class LogManager : IDataBusinessService<Log>
    {
        private IDataAccessDal<Log> _dataAccessDal;
        private readonly IMapper _mapper;

        public LogManager(IDataAccessDal<Log> dataAccessDal,IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Log entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Log Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Log> GetAll()
        {
            var _Log = _mapper.Map<List<Log>>(_dataAccessDal.GetAll());
            //var _Log = AutoMapperHelper.MapToSameTypeList(_dataAccessDal.GetAll());
            return _Log;
        }

        public IEnumerable<Log> GetFilter(Expression<Func<Log, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Log t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Log t)
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
