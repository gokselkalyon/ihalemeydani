using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class NatificationManager : IDataBusinessService<natification>
    {
        private IDataAccessDal<natification> _dataAccessDal;
        private readonly IMapper _mapper;

        public NatificationManager(IDataAccessDal<natification> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(natification entity)
        {
            _dataAccessDal.Add(entity);
        }

        public natification Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<natification> GetAll()
        {
            var natification = _mapper.Map<List<natification>>(_dataAccessDal.GetAll());
            return natification;
        }

        public IEnumerable<natification> GetFilter(Expression<Func<natification, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(natification t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(natification t)
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
