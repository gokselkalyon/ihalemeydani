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
    public class FuelTypeManager : IDataBusinessService<FuelType>
    {
        private IDataAccessDal<FuelType> _dataAccessDal;
        private readonly IMapper _mapper;

        public FuelTypeManager(IDataAccessDal<FuelType> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(FuelType entity)
        {
            _dataAccessDal.Add(entity);
        }

        public FuelType Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<FuelType> GetAll()
        {
            var FuelType = _mapper.Map<List<FuelType>>(_dataAccessDal.GetAll());
            return FuelType;
        }

        public IEnumerable<FuelType> GetFilter(Expression<Func<FuelType, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(FuelType t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(FuelType t)
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
