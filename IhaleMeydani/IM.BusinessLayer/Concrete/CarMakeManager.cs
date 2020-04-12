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
    public class CarMakeManagerr : IDataBusinessService<CarMake>
    {
        private IDataAccessDal<CarMake> _dataAccessDal;
        private readonly IMapper _mapper;

        public CarMakeManagerr(IDataAccessDal<CarMake> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(CarMake entity)
        {
            _dataAccessDal.Add(entity);
        }

        public CarMake Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<CarMake> GetAll()
        {
            var CarMake = _mapper.Map<List<CarMake>>(_dataAccessDal.GetAll());
            return CarMake;
        }

        public IEnumerable<CarMake> GetFilter(Expression<Func<CarMake, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(CarMake t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(CarMake t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
