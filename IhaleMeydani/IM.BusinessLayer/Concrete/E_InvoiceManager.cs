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
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class E_InvoiceManager : IDataBusinessService<E_INVOICE>
    {
        private IDataAccessDal<E_INVOICE> _dataAccessDal;
        private readonly IMapper _mapper;

        public E_InvoiceManager(IDataAccessDal<E_INVOICE> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(E_INVOICE entity)
        {
            _dataAccessDal.Add(entity);
        }

        public E_INVOICE Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<E_INVOICE> GetAll()
        {
            var E_INVOICE = _mapper.Map<List<E_INVOICE>>(_dataAccessDal.GetAll());
            return E_INVOICE;
        }

        public IEnumerable<E_INVOICE> GetFilter(Expression<Func<E_INVOICE, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(E_INVOICE t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(E_INVOICE t)
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
