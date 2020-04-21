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
    public class IconManager : IDataBusinessService<Icon>
    {
        private IDataAccessDal<Icon> _dataAccessDal;
        private readonly IMapper _mapper;

        public IconManager(IDataAccessDal<Icon> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Icon entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Icon Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Icon> GetAll()
        {
            var AMOUNT_OF_INCREASE = _mapper.Map<List<Icon>>(_dataAccessDal.GetAll());
            return AMOUNT_OF_INCREASE;
        }

        public IEnumerable<Icon> GetFilter(Expression<Func<Icon, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Icon t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Icon t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
