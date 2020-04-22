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
using System.Text;
using System.Threading.Tasks;


namespace IM.BusinessLayer.Concrete
{
    public class SocialMediaManager : IDataBusinessService<SocialMedya>
    {
        private IDataAccessDal<SocialMedya> _dataAccessDal;
        private readonly IMapper _mapper;

        public SocialMediaManager(IDataAccessDal<SocialMedya> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(SocialMedya entity)
        {
            _dataAccessDal.Add(entity);
        }

        public SocialMedya Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<SocialMedya> GetAll()
        {
            var SocialMedya = _mapper.Map<List<SocialMedya>>(_dataAccessDal.GetAll());
            return SocialMedya;
        }

        public IEnumerable<SocialMedya> GetFilter(Expression<Func<SocialMedya, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(SocialMedya t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(SocialMedya t)
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
