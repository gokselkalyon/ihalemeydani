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
    public class EmployeePositionManager : IDataBusinessService<employee_position>
    {
        private IDataAccessDal<employee_position> _dataAccessDal;
        private readonly IMapper _mapper;

        public EmployeePositionManager(IDataAccessDal<employee_position> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(employee_position entity)
        {
            _dataAccessDal.Add(entity);
        }

        public employee_position Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<employee_position> GetAll()
        {
            var employee_position = _mapper.Map<List<employee_position>>(_dataAccessDal.GetAll());
            return employee_position;
        }

        public IEnumerable<employee_position> GetFilter(Expression<Func<employee_position, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(employee_position t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(employee_position t)
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
