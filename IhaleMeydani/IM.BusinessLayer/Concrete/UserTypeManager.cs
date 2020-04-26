using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public  class UserTypeManager : IDataBusinessService<UserType>
    {
        private IDataAccessDal<UserType> _dataAccessDal;
        private readonly IMapper _mapper;

        public UserTypeManager(IDataAccessDal<UserType> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(UserType entity)
        {
            _dataAccessDal.Add(entity);
        }

        public UserType Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<UserType> GetAll()
        {
            var UserType = _mapper.Map<List<UserType>>(_dataAccessDal.GetAll());
            return UserType;
        }

        public IEnumerable<UserType> GetFilter(Expression<Func<UserType, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(UserType t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(UserType t)
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
