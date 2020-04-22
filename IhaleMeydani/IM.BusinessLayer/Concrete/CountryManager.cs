using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IM.BusinessLayer.Concrete
{
   public class CountryManager : IDataBusinessService<country>
    {
        private IDataAccessDal<country> _dataAccessDal;
        private readonly IMapper _mapper;

        public CountryManager(IDataAccessDal<country> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(country entity)
        {
            _dataAccessDal.Add(entity);
        }

        public country Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<country> GetAll()
        {
            var country = _mapper.Map<List<country>>(_dataAccessDal.GetAll());
            return country;
        }

        public IEnumerable<country> GetFilter(Expression<Func<country, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(country t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(country t)
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
