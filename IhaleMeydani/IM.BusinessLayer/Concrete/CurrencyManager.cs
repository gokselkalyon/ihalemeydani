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
using System.Threading.Tasks;
namespace IM.BusinessLayer.Concrete
{
    public class CurrencyManager : IDataBusinessService<CURRENCY>
    {
        private IDataAccessDal<CURRENCY> _dataAccessDal;
        private readonly IMapper _mapper;

        public CurrencyManager(IDataAccessDal<CURRENCY> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CURRENCY entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CURRENCY Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CURRENCY> GetAll()
        {
            var CURRENCY = _mapper.Map<List<CURRENCY>>(_dataAccessDal.GetAll());
            return CURRENCY;
        }

        public IEnumerable<CURRENCY> GetFilter(Expression<Func<CURRENCY, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CURRENCY t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CURRENCY t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
