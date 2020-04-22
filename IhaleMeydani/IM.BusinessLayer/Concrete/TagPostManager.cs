using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IM.BusinessLayer.Concrete
{
    public  class TagPostManager : IDataBusinessService<tag_post>
    {
        private IDataAccessDal<tag_post> _dataAccessDal;
        private readonly IMapper _mapper;

        public TagPostManager(IDataAccessDal<tag_post> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(tag_post entity)
        {
            _dataAccessDal.Add(entity);
        }

        public tag_post Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<tag_post> GetAll()
        {
            var tag_post = _mapper.Map<List<tag_post>>(_dataAccessDal.GetAll());
            return tag_post;
        }

        public IEnumerable<tag_post> GetFilter(Expression<Func<tag_post, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(tag_post t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(tag_post t)
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
