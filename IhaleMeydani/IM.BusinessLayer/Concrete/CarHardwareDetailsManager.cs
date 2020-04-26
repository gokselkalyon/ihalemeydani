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
    public class CarHardwareDetailsManager : IDataBusinessService<CarHardwareDetail>
    {
        private IDataAccessDal<CarHardwareDetail> _dataAccessDal;
        private readonly IMapper _mapper;

        public CarHardwareDetailsManager(IDataAccessDal<CarHardwareDetail> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CarHardwareDetail entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CarHardwareDetail Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CarHardwareDetail> GetAll()
        {
            var CarHardwareDetail = _mapper.Map<List<CarHardwareDetail>>(_dataAccessDal.GetAll());
            return CarHardwareDetail;
        }

        public IEnumerable<CarHardwareDetail> GetFilter(Expression<Func<CarHardwareDetail, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CarHardwareDetail t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CarHardwareDetail t)
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
