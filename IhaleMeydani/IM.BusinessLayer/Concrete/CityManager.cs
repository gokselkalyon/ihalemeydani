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
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class CityManager : IDataBusinessService<city>
    {
        private IDataAccessDal<city> _dataAccessDal;
        private readonly IMapper _mapper;

        public CityManager(IDataAccessDal<city> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(city entity)
        {
            _dataAccessDal.Add(entity);
        }

        public city Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<city> GetAll()
        {
            var city = _mapper.Map<List<city>>(_dataAccessDal.GetAll());
            return city;
        }

        public IEnumerable<city> GetFilter(Expression<Func<city, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(city t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(city t)
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
