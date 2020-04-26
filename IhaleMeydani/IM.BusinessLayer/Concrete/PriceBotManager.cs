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
    public class PriceBotManager : IDataBusinessService<PRICEBOT>
    {
        private IDataAccessDal<PRICEBOT> _dataAccessDal;
        private readonly IMapper _mapper;

        public PriceBotManager(IDataAccessDal<PRICEBOT> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(PRICEBOT entity)
        {
            _dataAccessDal.Add(entity);
        }

        public PRICEBOT Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<PRICEBOT> GetAll()
        {
            var PRICEBOT = _mapper.Map<List<PRICEBOT>>(_dataAccessDal.GetAll());
            return PRICEBOT;
        }

        public IEnumerable<PRICEBOT> GetFilter(Expression<Func<PRICEBOT, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(PRICEBOT t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(PRICEBOT t)
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
