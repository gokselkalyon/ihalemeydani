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
    public class BankManager : IDataBusinessService<bank>
    {
        private IDataAccessDal<bank> _dataAccessDal;
        private readonly IMapper _mapper;

        public BankManager(IDataAccessDal<bank> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(bank entity)
        {
            _dataAccessDal.Add(entity);
        }

        public bank Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<bank> GetAll()
        {
            var bank = _mapper.Map<List<bank>>(_dataAccessDal.GetAll());
            return bank;
        }

        public IEnumerable<bank> GetFilter(Expression<Func<bank, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(bank t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(bank t)
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
