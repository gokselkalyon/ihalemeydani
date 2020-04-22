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

namespace IM.BusinessLayer.Concrete
{
    public class UserRoleManager : IDataBusinessService<UserRole>
    {
        private IDataAccessDal<UserRole> _dataAccessDal;
        private readonly IMapper _mapper;

        public UserRoleManager(IDataAccessDal<UserRole> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(UserRole entity)
        {
            _dataAccessDal.Add(entity);
        }

        public UserRole Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<UserRole> GetAll()
        {
            var UserRole = _mapper.Map<List<UserRole>>(_dataAccessDal.GetAll());
            return UserRole;
        }

        public IEnumerable<UserRole> GetFilter(Expression<Func<UserRole, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(UserRole t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(UserRole t)
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
