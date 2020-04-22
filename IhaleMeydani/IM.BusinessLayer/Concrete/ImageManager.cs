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
    public class ImageManager : IDataBusinessService<Image>
    {
        private IDataAccessDal<Image> _dataAccessDal;
        private readonly IMapper _mapper;

        public ImageManager(IDataAccessDal<Image> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Image entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Image Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Image> GetAll()
        {
            var Image = _mapper.Map<List<Image>>(_dataAccessDal.GetAll());
            return Image;
        }

        public IEnumerable<Image> GetFilter(Expression<Func<Image, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Image t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Image t)
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
