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
using System.Text;

namespace IM.BusinessLayer.Concrete
{
    public class CountyManager : IDataBusinessService<county>
    {
        private IDataAccessDal<county> _dataAccessDal;
        private readonly IMapper _mapper;

        public CountyManager(IDataAccessDal<county> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(county entity)
        {
            _dataAccessDal.Add(entity);
        }

        public county Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<county> GetAll()
        {
            var county = _mapper.Map<List<county>>(_dataAccessDal.GetAll());
            return county;
        }

        public IEnumerable<county> GetFilter(Expression<Func<county, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(county t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(county t)
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
