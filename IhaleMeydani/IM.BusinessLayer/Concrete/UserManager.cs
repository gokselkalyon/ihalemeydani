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
    public class UserManager : IDataBusinessService<User>
    {
        private IDataAccessDal<User> _dataAccessDal;
        private readonly IMapper _mapper;

        public UserManager(IDataAccessDal<User> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(User entity)
        {
            _dataAccessDal.Add(entity);
        }

        public User Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<User> GetAll()
        {
            var User = _mapper.Map<List<User>>(_dataAccessDal.GetAll());
            return User;
        }

        public IEnumerable<User> GetFilter(Expression<Func<User, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(User t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(User t)
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
