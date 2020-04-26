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
    public class CompanyManager : IDataBusinessService<company>
    {
        private IDataAccessDal<company> _dataAccessDal;
        private readonly IMapper _mapper;

        public CompanyManager(IDataAccessDal<company> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(company entity)
        {
            _dataAccessDal.Add(entity);
        }

        public company Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<company> GetAll()
        {
            var company = _mapper.Map<List<company>>(_dataAccessDal.GetAll());
            return company;
        }

        public IEnumerable<company> GetFilter(Expression<Func<company, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(company t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(company t)
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
