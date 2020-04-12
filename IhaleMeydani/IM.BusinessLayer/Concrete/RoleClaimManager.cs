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
    class RoleClaimManager : IDataBusinessService<RoleClaim>
    {
        private IDataAccessDal<RoleClaim> _dataAccessDal;
        private readonly IMapper _mapper;

        public RoleClaimManager(IDataAccessDal<RoleClaim> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(RoleClaim entity)
        {
            _dataAccessDal.Add(entity);
        }

        public RoleClaim Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<RoleClaim> GetAll()
        {
            var RoleClaim = _mapper.Map<List<RoleClaim>>(_dataAccessDal.GetAll());
            return RoleClaim;
        }

        public IEnumerable<RoleClaim> GetFilter(Expression<Func<RoleClaim, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(RoleClaim t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(RoleClaim t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
