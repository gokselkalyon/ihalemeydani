using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class ContactManager : IDataBusinessService<Contact>,IDisposable
    {
        private IDataAccessDal<Contact> _dataAccessDal;
        private readonly IMapper _mapper;

        public ContactManager(IDataAccessDal<Contact> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }


        public void Add(Contact entity)
        {
            _dataAccessDal.Add(entity);
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

        public Contact Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Contact> GetAll()
        {
            var contacts = _mapper.Map<List<Contact>>(_dataAccessDal.GetAll());
            return contacts;
        }

        public IEnumerable<Contact> GetFilter(Expression<Func<Contact, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Contact t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Contact t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
