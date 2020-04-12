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
    public class FuelTypeManager : IDataBusinessService<FuelType>
    {
        private IDataAccessDal<FuelType> _dataAccessDal;
        private readonly IMapper _mapper;

        public FuelTypeManager(IDataAccessDal<FuelType> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(FuelType entity)
        {
            _dataAccessDal.Add(entity);
        }

        public FuelType Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<FuelType> GetAll()
        {
            var FuelType = _mapper.Map<List<FuelType>>(_dataAccessDal.GetAll());
            return FuelType;
        }

        public IEnumerable<FuelType> GetFilter(Expression<Func<FuelType, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(FuelType t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(FuelType t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
