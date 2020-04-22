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
namespace IM.BusinessLayer.Concrete
{
    public class DiscountCartManager : IDataBusinessService<discountcart>
    {
        private IDataAccessDal<discountcart> _dataAccessDal;
        private readonly IMapper _mapper;

        public DiscountCartManager(IDataAccessDal<discountcart> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(discountcart entity)
        {
            _dataAccessDal.Add(entity);
        }

        public discountcart Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<discountcart> GetAll()
        {
            var discountcart = _mapper.Map<List<discountcart>>(_dataAccessDal.GetAll());
            return discountcart;
        }

        public IEnumerable<discountcart> GetFilter(Expression<Func<discountcart, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(discountcart t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(discountcart t)
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
