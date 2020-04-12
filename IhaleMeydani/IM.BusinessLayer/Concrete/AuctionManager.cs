﻿using AutoMapper;
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
    public class AuctionManager : IDataBusinessService<auction>
    {
        private IDataAccessDal<auction> _dataAccessDal;
        private readonly IMapper _mapper;

        public AuctionManager(IDataAccessDal<auction> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(auction entity)
        {
            _dataAccessDal.Add(entity);
        }

        public auction Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<auction> GetAll()
        {
            var auction = _mapper.Map<List<auction>>(_dataAccessDal.GetAll());
            return auction;
        }

        public IEnumerable<auction> GetFilter(Expression<Func<auction, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(auction t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(auction t)
        {
            _dataAccessDal.Update(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
