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
    public class ClaimManager : IDataBusinessService<Claim>
    {
        private IDataAccessDal<Claim> _dataAccessDal;
        private readonly IMapper _mapper;

        public ClaimManager(IDataAccessDal<Claim> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Claim entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Claim Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Claim> GetAll()
        {
            var Claim = _mapper.Map<List<Claim>>(_dataAccessDal.GetAll());
            return Claim;
        }

        public IEnumerable<Claim> GetFilter(Expression<Func<Claim, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Claim t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Claim t)
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
