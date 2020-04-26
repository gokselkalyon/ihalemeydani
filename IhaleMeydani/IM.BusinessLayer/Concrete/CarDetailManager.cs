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
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace IM.BusinessLayer.Concrete
{
    public class CarDetailManager : IDataBusinessService<CarDetail>
    {
        private IDataAccessDal<CarDetail> _dataAccessDal;
        private readonly IMapper _mapper;

        public CarDetailManager(IDataAccessDal<CarDetail> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CarDetail entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CarDetail Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CarDetail> GetAll()
        {
            var CarDetail = _mapper.Map<List<CarDetail>>(_dataAccessDal.GetAll());
            return CarDetail;
        }

        public IEnumerable<CarDetail> GetFilter(Expression<Func<CarDetail, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CarDetail t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CarDetail t)
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
