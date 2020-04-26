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
    public class SoldProductManager : IDataBusinessService<SOLD_PRODUCT>
    {
        private IDataAccessDal<SOLD_PRODUCT> _dataAccessDal;
        private readonly IMapper _mapper;

        public SoldProductManager(IDataAccessDal<SOLD_PRODUCT> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(SOLD_PRODUCT entity)
        {
            _dataAccessDal.Add(entity);
        }

        public SOLD_PRODUCT Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<SOLD_PRODUCT> GetAll()
        {
            var SOLD_PRODUCT = _mapper.Map<List<SOLD_PRODUCT>>(_dataAccessDal.GetAll());
            return SOLD_PRODUCT;
        }

        public IEnumerable<SOLD_PRODUCT> GetFilter(Expression<Func<SOLD_PRODUCT, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(SOLD_PRODUCT t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(SOLD_PRODUCT t)
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
