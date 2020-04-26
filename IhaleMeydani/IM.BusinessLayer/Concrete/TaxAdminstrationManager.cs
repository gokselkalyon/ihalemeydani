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

namespace IM.BusinessLayer.Concrete
{
    public class TaxAdminstrationManager : IDataBusinessService<Tax_Administration>
    {
        private IDataAccessDal<Tax_Administration> _dataAccessDal;
        private readonly IMapper _mapper;

        public TaxAdminstrationManager(IDataAccessDal<Tax_Administration> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Tax_Administration entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Tax_Administration Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Tax_Administration> GetAll()
        {
            var Tax_Administration = _mapper.Map<List<Tax_Administration>>(_dataAccessDal.GetAll());
            return Tax_Administration;
        }

        public IEnumerable<Tax_Administration> GetFilter(Expression<Func<Tax_Administration, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Tax_Administration t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Tax_Administration t)
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
