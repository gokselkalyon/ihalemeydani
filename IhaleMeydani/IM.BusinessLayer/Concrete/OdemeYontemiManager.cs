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
    public class OdemeYontemiManager : IDataBusinessService<odeme_yontemi>
    {
        private IDataAccessDal<odeme_yontemi> _dataAccessDal;
        private readonly IMapper _mapper;

        public OdemeYontemiManager(IDataAccessDal<odeme_yontemi> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(odeme_yontemi entity)
        {
            _dataAccessDal.Add(entity);
        }

        public odeme_yontemi Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<odeme_yontemi> GetAll()
        {
            var odeme_yontemi = _mapper.Map<List<odeme_yontemi>>(_dataAccessDal.GetAll());
            return odeme_yontemi;
        }

        public IEnumerable<odeme_yontemi> GetFilter(Expression<Func<odeme_yontemi, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(odeme_yontemi t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(odeme_yontemi t)
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
