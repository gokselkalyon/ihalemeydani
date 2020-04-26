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
    public class PrivateAuctionManager : IDataBusinessService<private_auction>
    {
        private IDataAccessDal<private_auction> _dataAccessDal;
        private readonly IMapper _mapper;

        public PrivateAuctionManager(IDataAccessDal<private_auction> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(private_auction entity)
        {
            _dataAccessDal.Add(entity);
        }

        public private_auction Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<private_auction> GetAll()
        {
            var privateauction = _mapper.Map<List<private_auction>>(_dataAccessDal.GetAll());
            return privateauction;
        }

        public IEnumerable<private_auction> GetFilter(Expression<Func<private_auction, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(private_auction t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(private_auction t)
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
