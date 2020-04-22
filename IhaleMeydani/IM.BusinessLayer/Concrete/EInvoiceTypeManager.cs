using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Text;

namespace IM.BusinessLayer.Concrete
{
    public class EInvoiceTypeManager : IDataBusinessService<E_invoice_type>
    {
        private IDataAccessDal<E_invoice_type> _dataAccessDal;
        private readonly IMapper _mapper;

        public EInvoiceTypeManager(IDataAccessDal<E_invoice_type> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(E_invoice_type entity)
        {
            _dataAccessDal.Add(entity);
        }

        public E_invoice_type Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<E_invoice_type> GetAll()
        {
            var E_invoice_type = _mapper.Map<List<E_invoice_type>>(_dataAccessDal.GetAll());
            return E_invoice_type;
        }

        public IEnumerable<E_invoice_type> GetFilter(Expression<Func<E_invoice_type, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(E_invoice_type t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(E_invoice_type t)
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
