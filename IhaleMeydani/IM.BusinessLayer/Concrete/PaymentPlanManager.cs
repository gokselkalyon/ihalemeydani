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
    public class PaymentPlanManager : IDataBusinessService<payment_plan>
    {
        private IDataAccessDal<payment_plan> _dataAccessDal;
        private readonly IMapper _mapper;

        public PaymentPlanManager(IDataAccessDal<payment_plan> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(payment_plan entity)
        {
            _dataAccessDal.Add(entity);
        }

        public payment_plan Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<payment_plan> GetAll()
        {
            var payment_plan = _mapper.Map<List<payment_plan>>(_dataAccessDal.GetAll()); 
            return payment_plan;
        }

        public IEnumerable<payment_plan> GetFilter(Expression<Func<payment_plan, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(payment_plan t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(payment_plan t)
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
