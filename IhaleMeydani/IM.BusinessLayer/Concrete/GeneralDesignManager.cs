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
    public class GeneralDesignManager : IDataBusinessService<GeneralDesign>
    {
        private IDataAccessDal<GeneralDesign> _dataAccessDal;
        private readonly IMapper _mapper;

        public GeneralDesignManager(IDataAccessDal<GeneralDesign> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(GeneralDesign entity)
        {
            _dataAccessDal.Add(entity);
        }

        public GeneralDesign Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<GeneralDesign> GetAll()
        {
            var GeneralDesign = _mapper.Map<List<GeneralDesign>>(_dataAccessDal.GetAll());
            return GeneralDesign;
        }

        public IEnumerable<GeneralDesign> GetFilter(Expression<Func<GeneralDesign, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(GeneralDesign t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(GeneralDesign t)
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
