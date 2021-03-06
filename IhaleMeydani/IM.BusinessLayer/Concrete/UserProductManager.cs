﻿using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using IM.DataLayer.Model;
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
    public class UserProductManager : IDataBusinessService<userproduct>, IDataBaseQueryService<UserProductModel>
    {
        private IDataAccessDal<userproduct> _dataAccessDal;
        private readonly IMapper _mapper;
        private IDataBaseQuery<UserProductModel> _query;

        public UserProductManager(IDataAccessDal<userproduct> dataAccessDal, IMapper mapper,IDataBaseQuery<UserProductModel> query)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
            _query = query;
        }
        public void Add(userproduct entity)
        {
            _dataAccessDal.Add(entity);
        }


        public userproduct Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<userproduct> GetAll()
        {
           return _dataAccessDal.GetAll();
             
        }
        public IEnumerable<userproduct> GetFilter(Expression<Func<userproduct, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(userproduct t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(userproduct t)
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

        public List<UserProductModel> QueryList()
        {
            return _query.QueryList();
        }

        public int MultiAdded(UserProductModel t)
        {
           return _query.MultiAdded(t);
        }

        public int Multiupdate(UserProductModel t)
        {
            return _query.Multiupdate(t);
        }
    }
}
