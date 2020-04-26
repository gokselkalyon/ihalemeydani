using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Linq;
using System.Linq.Expressions;

namespace IM.BusinessLayer.Concrete
{
    public class SegmentManager : IDataBusinessService<Segment>
    {
        private IDataAccessDal<Segment> _dataAccessDal;
        private readonly IMapper _mapper;

        public SegmentManager(IDataAccessDal<Segment> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Segment entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Segment Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Segment> GetAll()
        {
            var Segment = _mapper.Map<List<Segment>>(_dataAccessDal.GetAll());
            return Segment;
        }

        public IEnumerable<Segment> GetFilter(Expression<Func<Segment, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Segment t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Segment t)
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
