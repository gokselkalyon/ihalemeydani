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
    public class CompanyTypeManager : IDataBusinessService<company_type>
    {
        private IDataAccessDal<company_type> _dataAccessDal;
        private readonly IMapper _mapper;

        public CompanyTypeManager(IDataAccessDal<company_type> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(company_type entity)
        {
            _dataAccessDal.Add(entity);
        }

        public company_type Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<company_type> GetAll()
        {
            var company_type = _mapper.Map<List<company_type>>(_dataAccessDal.GetAll());
            return company_type;
        }

        public IEnumerable<company_type> GetFilter(Expression<Func<company_type, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(company_type t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(company_type t)
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
