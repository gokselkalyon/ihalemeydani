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
    public class ClaimGroupManager : IDataBusinessService<ClaimGroup>
    {
        private IDataAccessDal<ClaimGroup> _dataAccessDal;
        private readonly IMapper _mapper;

        public ClaimGroupManager(IDataAccessDal<ClaimGroup> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(ClaimGroup entity)
        {
            _dataAccessDal.Add(entity);
        }

        public ClaimGroup Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<ClaimGroup> GetAll()
        { 
            return _dataAccessDal.GetAll();
        }

        public IEnumerable<ClaimGroup> GetFilter(Expression<Func<ClaimGroup, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(ClaimGroup t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(ClaimGroup t)
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
