using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IM.DataLayer.Model;

namespace IM.BusinessLayer.Concrete
{
    public class PostManager:IDataBusinessService<Post>,IDataBaseQueryService<PostModel>
    {
        private IDataAccessDal<Post> _dataAccessDal;
        private readonly IMapper _mapper;
        private IDataBaseQuery<PostModel> _query;
        public PostManager(IDataAccessDal<Post> dataAccessDal, IMapper mapper,IDataBaseQuery<PostModel> query)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
            _query = query;
        }
        public void Add(Post entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Post Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Post> GetAll()
        {
            var AMOUNT_OF_INCREASE = _mapper.Map<List<Post>>(_dataAccessDal.GetAll());
            return AMOUNT_OF_INCREASE;
        }

        public IEnumerable<Post> GetFilter(Expression<Func<Post, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Post t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Post t)
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

        public List<PostModel> QueryList()
        {
            return _query.QueryList();
        }

        public int Multiupdate(PostModel t)
        {
            return _query.Multiupdate(t);
        }

        public int MultiAdded(PostModel t)
        {
            return _query.MultiAdded(t);
        }
    }
}
