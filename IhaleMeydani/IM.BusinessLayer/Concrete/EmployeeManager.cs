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
    public class EmployeeManager : IDataBusinessService<employee>
    {
        private IDataAccessDal<employee> _dataAccessDal;
        private readonly IMapper _mapper;

        public EmployeeManager(IDataAccessDal<employee> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(employee entity)
        {
            _dataAccessDal.Add(entity);
        }

        public employee Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<employee> GetAll()
        {
            var employee = _mapper.Map<List<employee>>(_dataAccessDal.GetAll());
            return employee;
        }

        public IEnumerable<employee> GetFilter(Expression<Func<employee, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(employee t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(employee t)
        {
            _dataAccessDal.Update(t);
        }
    }
}
