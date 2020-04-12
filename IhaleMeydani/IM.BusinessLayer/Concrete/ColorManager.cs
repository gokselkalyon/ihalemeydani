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
    public class ColorManager : IDataBusinessService<Color>
    {
        private IDataAccessDal<Color> _dataAccessDal;
        private readonly IMapper _mapper;

        public ColorManager(IDataAccessDal<Color> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(Color entity)
        {
            _dataAccessDal.Add(entity);
        }

        public Color Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<Color> GetAll()
        {
            var Color = _mapper.Map<List<Color>>(_dataAccessDal.GetAll());
            return Color;
        }

        public IEnumerable<Color> GetFilter(Expression<Func<Color, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(Color t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(Color t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
