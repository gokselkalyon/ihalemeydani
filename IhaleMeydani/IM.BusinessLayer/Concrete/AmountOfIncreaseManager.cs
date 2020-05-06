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
    public class AmountOfIncreaseManager : IDataBusinessService<AMOUNT_OF_INCREASE>
    {
        private IDataAccessDal<AMOUNT_OF_INCREASE> _dataAccessDal;
        private readonly IMapper _mapper;

        public AmountOfIncreaseManager(IDataAccessDal<AMOUNT_OF_INCREASE> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(AMOUNT_OF_INCREASE entity)
        {
            _dataAccessDal.Add(entity);
        }

        public AMOUNT_OF_INCREASE Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<AMOUNT_OF_INCREASE> GetAll()
        {
            var AMOUNT_OF_INCREASE = _mapper.Map<List<AMOUNT_OF_INCREASE>>(_dataAccessDal.GetAll()); 
            return AMOUNT_OF_INCREASE;
        }

        public IEnumerable<AMOUNT_OF_INCREASE> GetFilter(Expression<Func<AMOUNT_OF_INCREASE, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(AMOUNT_OF_INCREASE t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(AMOUNT_OF_INCREASE t)
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
