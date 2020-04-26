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
    public  class SeneryoManager : IDataBusinessService<senaryo>
    {
        private IDataAccessDal<senaryo> _dataAccessDal;
        private readonly IMapper _mapper;

        public SeneryoManager(IDataAccessDal<senaryo> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(senaryo entity)
        {
            _dataAccessDal.Add(entity);
        }

        public senaryo Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<senaryo> GetAll()
        {
            var senaryo = _mapper.Map<List<senaryo>>(_dataAccessDal.GetAll());
            return senaryo;
        }

        public IEnumerable<senaryo> GetFilter(Expression<Func<senaryo, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(senaryo t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(senaryo t)
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
