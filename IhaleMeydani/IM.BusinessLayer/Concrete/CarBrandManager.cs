using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
     public class CarBrandManager : IDataBusinessService<CarBrand>
    {
        private IDataAccessDal<CarBrand> _dataAccessDal;
        private readonly IMapper _mapper;

        public CarBrandManager(IDataAccessDal<CarBrand> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CarBrand entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CarBrand Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CarBrand> GetAll()
        {
            var CarBrand = _mapper.Map<List<CarBrand>>(_dataAccessDal.GetAll());
            return CarBrand;
        }

        public IEnumerable<CarBrand> GetFilter(Expression<Func<CarBrand, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CarBrand t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CarBrand t)
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
