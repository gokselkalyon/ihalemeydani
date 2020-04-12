using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IM.BusinessLayer.Concrete
{
    public class TagManager : IDataBusinessService<tag>
    {
        private IDataAccessDal<tag> _dataAccessDal;
        private readonly IMapper _mapper;

        public TagManager(IDataAccessDal<tag> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(tag entity)
        {
            _dataAccessDal.Add(entity);
        }

        public tag Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<tag> GetAll()
        {
            var tag = _mapper.Map<List<tag>>(_dataAccessDal.GetAll());
            return tag;
        }

        public IEnumerable<tag> GetFilter(Expression<Func<tag, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(tag t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(tag t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
