using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

namespace IM.BusinessLayer.Concrete
{
    public class MediumManager : IDataBusinessService<medium>
    {
        private IDataAccessDal<medium> _dataAccessDal;
        private readonly IMapper _mapper;

        public MediumManager(IDataAccessDal<medium> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(medium entity)
        {
            _dataAccessDal.Add(entity);
        }

        public medium Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<medium> GetAll()
        {
            var medium = _mapper.Map<List<medium>>(_dataAccessDal.GetAll());
            return medium;
        }

        public IEnumerable<medium> GetFilter(Expression<Func<medium, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(medium t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(medium t)
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
