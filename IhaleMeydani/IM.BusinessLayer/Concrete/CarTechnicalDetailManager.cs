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
    public class CarTechnicalDetailManager : IDataBusinessService<CarTechnicalDetail>
    {
        private IDataAccessDal<CarTechnicalDetail> _dataAccessDal;
        private readonly IMapper _mapper;

        public CarTechnicalDetailManager(IDataAccessDal<CarTechnicalDetail> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CarTechnicalDetail entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CarTechnicalDetail Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CarTechnicalDetail> GetAll()
        {
            var CarTechnicalDetail = _mapper.Map<List<CarTechnicalDetail>>(_dataAccessDal.GetAll());
            return CarTechnicalDetail;
        }

        public IEnumerable<CarTechnicalDetail> GetFilter(Expression<Func<CarTechnicalDetail, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CarTechnicalDetail t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CarTechnicalDetail t)
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
