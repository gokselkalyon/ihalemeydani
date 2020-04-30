using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class AuctionUserManager : IDataBusinessService<actionuser>
    {
        private IDataAccessDal<actionuser> _dataAccessDal;
        private readonly IMapper _mapper;

        public AuctionUserManager(IDataAccessDal<actionuser> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(actionuser entity)
        {
            _dataAccessDal.Add(entity);
        }

        public actionuser Get(int id)
        {
            return _dataAccessDal.Get(id);
        }
        
        public List<actionuser> GetAll()
        {
            var auctionuser = _mapper.Map<List<actionuser>>(_dataAccessDal.GetAll());
            return auctionuser;
        }

        public IEnumerable<actionuser> GetFilter(Expression<Func<actionuser, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(actionuser t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(actionuser t)
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
