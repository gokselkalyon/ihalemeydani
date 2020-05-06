using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class LogInfoesManager : IDataBusinessService<LogInfo>
    {
        private IDataAccessDal<LogInfo> _dataAccessDal;
        private readonly IMapper _mapper;

        public LogInfoesManager(IDataAccessDal<LogInfo> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(LogInfo entity)
        {
            _dataAccessDal.Add(entity);
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

        public LogInfo Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<LogInfo> GetAll()
        {
            var _Log = _mapper.Map<List<LogInfo>>(_dataAccessDal.GetAll());
            //var _Log = AutoMapperHelper.MapToSameTypeList(_dataAccessDal.GetAll());
            return _Log;
        }

        public IEnumerable<LogInfo> GetFilter(Expression<Func<LogInfo, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(LogInfo t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(LogInfo t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
