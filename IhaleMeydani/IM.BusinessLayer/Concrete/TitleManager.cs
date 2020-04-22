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
    public class TitleManager : IDataBusinessService<title>
    {
        private IDataAccessDal<title> _dataAccessDal;
        private readonly IMapper _mapper;

        public TitleManager(IDataAccessDal<title> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(title entity)
        {
            _dataAccessDal.Add(entity);
        }

        public title Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<title> GetAll()
        {
            var title = _mapper.Map<List<title>>(_dataAccessDal.GetAll());
            return title;
        }

        public IEnumerable<title> GetFilter(Expression<Func<title, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(title t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(title t)
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
