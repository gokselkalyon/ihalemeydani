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

namespace IM.BusinessLayer.Concrete
{
    public class MenuManager : IDataBusinessService<Menu>
    {
        private IDataAccessDal<Menu> _dataAccessDal;
        private readonly IMapper _mapper;

        public MenuManager(IDataAccessDal<Menu> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Menu entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Menu Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Menu> GetAll()
        {
            var Menu = _mapper.Map<List<Menu>>(_dataAccessDal.GetAll());
            return Menu;
        }

        public IEnumerable<Menu> GetFilter(Expression<Func<Menu, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Menu t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Menu t)
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
