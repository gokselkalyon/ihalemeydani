using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class SubmitManager:IDataBusinessService<submit>
    {
        private IDataAccessDal<submit> _dataAccessDal;
        private readonly IMapper _mapper;

        public SubmitManager(IDataAccessDal<submit> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(submit entity)
        {
            _dataAccessDal.Add(entity);
        }

        public submit Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<submit> GetAll()
        {
            var AMOUNT_OF_INCREASE = _mapper.Map<List<submit>>(_dataAccessDal.GetAll());
            return AMOUNT_OF_INCREASE;
        }

        public IEnumerable<submit> GetFilter(Expression<Func<submit, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(submit t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(submit t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
