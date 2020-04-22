using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IM.BusinessLayer.Concrete
{
    public class RoleManager : IDataBusinessService<Role>
    {
        private IDataAccessDal<Role> _dataAccessDal;
        private readonly IMapper _mapper;

        public RoleManager(IDataAccessDal<Role> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Role entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Role Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Role> GetAll()
        {
            var Role = _mapper.Map<List<Role>>(_dataAccessDal.GetAll());
            return Role;
        }

        public IEnumerable<Role> GetFilter(Expression<Func<Role, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Role t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Role t)
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
