using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.DependencyResolver;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IM.ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IhaleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IhaleService.svc or IhaleService.svc.cs at the Solution Explorer and start debugging.
    public class IhaleService : IIhaleService
    {
        #region log
        public void AddLog(log entity)
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                _db.Add(entity);
            }
        }

        public log GetLog(int Id)
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                return _db.Get(Id);
            }
        }

        public List<log> GetLogs()
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                return _db.GetAll();
            }
        }

        public void RemoveLog(int Id)
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateLog(log entity)
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                _db.Update(entity);
            }
        }
        #endregion

        #region AMOUNT_OF_INCREASE
        public void UpdateAmountofIncrease(AMOUNT_OF_INCREASE entity)
        {
            using (IDataBusinessService<AMOUNT_OF_INCREASE> _db = InstanceFactory.GetInstance<IDataBusinessService<AMOUNT_OF_INCREASE>>())
            {
                _db.Update(entity);
            }
        }

        public AMOUNT_OF_INCREASE GetAmountofIncrease(int Id)
        {
            using (IDataBusinessService<AMOUNT_OF_INCREASE> _db = InstanceFactory.GetInstance<IDataBusinessService<AMOUNT_OF_INCREASE>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddAmountofIncrease(AMOUNT_OF_INCREASE entity)
        {
            using (IDataBusinessService<AMOUNT_OF_INCREASE> _db = InstanceFactory.GetInstance<IDataBusinessService<AMOUNT_OF_INCREASE>>())
            {
                _db.Add(entity);
            }
        }

        public List<AMOUNT_OF_INCREASE> GetsAmountofIncrease()
        {
            using (IDataBusinessService<AMOUNT_OF_INCREASE> _db = InstanceFactory.GetInstance<IDataBusinessService<AMOUNT_OF_INCREASE>>())
            {
                return _db.GetAll();
            }
        }

        public void RemoveAmountofIncrease(int Id)
        {
            using (IDataBusinessService<AMOUNT_OF_INCREASE> _db = InstanceFactory.GetInstance<IDataBusinessService<AMOUNT_OF_INCREASE>>())
            {
                _db.Remove(Id);
            }
        }
        #endregion

        #region auction
        public List<auction> GetAuctions()
        {
            using (IDataBusinessService<auction> _db = InstanceFactory.GetInstance<IDataBusinessService<auction>>())
            {
                return _db.GetAll();
            }
        }

        auction IIhaleService.GetAuction(int Id)
        {
            using (IDataBusinessService<auction> _db = InstanceFactory.GetInstance<IDataBusinessService<auction>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddAuction(auction entity)
        {
            using (IDataBusinessService<auction> _db = InstanceFactory.GetInstance<IDataBusinessService<auction>>())
            {
                _db.Add(entity);
            }
        }

        public void UpdateAuction(auction entity)
        {
            using (IDataBusinessService<auction> _db = InstanceFactory.GetInstance<IDataBusinessService<auction>>())
            {
                _db.Update(entity);
            }
        }

        public void RemoveAuction(int Id)
        {
            using (IDataBusinessService<auction> _db = InstanceFactory.GetInstance<IDataBusinessService<auction>>())
            {
                _db.Remove(Id);
            }
        }
        #endregion

        #region bank

        public List<bank> GetBanks()
        {
            using (IDataBusinessService<bank> _db = InstanceFactory.GetInstance<IDataBusinessService<bank>>())
            {
                return _db.GetAll();
            }
        }

        public bank GetBank(int Id)
        {
            using (IDataBusinessService<bank> _db = InstanceFactory.GetInstance<IDataBusinessService<bank>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddBank(bank entity)
        {
            using (IDataBusinessService<bank> _db = InstanceFactory.GetInstance<IDataBusinessService<bank>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveBank(int Id)
        {
            using (IDataBusinessService<bank> _db = InstanceFactory.GetInstance<IDataBusinessService<bank>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateBank(bank entity)
        {
            using (IDataBusinessService<bank> _db = InstanceFactory.GetInstance<IDataBusinessService<bank>>())
            {
                _db.Update(entity);
            }
        }
        #endregion

        #region CarBrand

        public List<CarBrand> GetCarBrands()
        {
            using (IDataBusinessService<CarBrand> _db = InstanceFactory.GetInstance<IDataBusinessService<CarBrand>>())
            {
                return _db.GetAll();
            }
        }

        public CarBrand GetCarBrand(int Id)
        {
            using (IDataBusinessService<CarBrand> _db = InstanceFactory.GetInstance<IDataBusinessService<CarBrand>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCarBrand(CarBrand entity)
        {
            using (IDataBusinessService<CarBrand> _db = InstanceFactory.GetInstance<IDataBusinessService<CarBrand>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCarBrand(int Id)
        {
            using (IDataBusinessService<CarBrand> _db = InstanceFactory.GetInstance<IDataBusinessService<CarBrand>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCarBrand(CarBrand entity)
        {
            using (IDataBusinessService<CarBrand> _db = InstanceFactory.GetInstance<IDataBusinessService<CarBrand>>())
            {
                _db.Update(entity);
            }
        }
        #endregion

        #region CarDetail

        public List<CarDetail> GetCarDetails()
        {
            using (IDataBusinessService<CarDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarDetail>>())
            {
                return _db.GetAll();
            }
        }

        public CarDetail GetCarDetail(int Id)
        {
            using (IDataBusinessService<CarDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarDetail>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCarDetail(CarDetail entity)
        {
            using (IDataBusinessService<CarDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarDetail>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCarDetail(int Id)
        {
            using (IDataBusinessService<CarDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarDetail>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCarDetail(CarDetail entity)
        {
            using (IDataBusinessService<CarDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarDetail>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region CarHardwareDetail
        public List<CarHardwareDetail> GetCarHardwareDetails()
        {
            using (IDataBusinessService<CarHardwareDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarHardwareDetail>>())
            {
                return _db.GetAll();
            }
        }

        public CarHardwareDetail GetCarHardwareDetail(int Id)
        {
            using (IDataBusinessService<CarHardwareDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarHardwareDetail>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCarHardwareDetail(CarHardwareDetail entity)
        {
            using (IDataBusinessService<CarHardwareDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarHardwareDetail>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCarHardwareDetail(int Id)
        {
            using (IDataBusinessService<CarHardwareDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarHardwareDetail>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCarHardwareDetail(CarHardwareDetail entity)
        {
            using (IDataBusinessService<CarHardwareDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarHardwareDetail>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region CarMake
        public List<CarMake> GetCarMakes()
        {
            using (IDataBusinessService<CarMake> _db = InstanceFactory.GetInstance<IDataBusinessService<CarMake>>())
            {
                return _db.GetAll();
            }
        }

        public CarMake GetCarMake(int Id)
        {
            using (IDataBusinessService<CarMake> _db = InstanceFactory.GetInstance<IDataBusinessService<CarMake>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCarMake(CarMake entity)
        {
            using (IDataBusinessService<CarMake> _db = InstanceFactory.GetInstance<IDataBusinessService<CarMake>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCarMake(int Id)
        {
            using (IDataBusinessService<CarMake> _db = InstanceFactory.GetInstance<IDataBusinessService<CarMake>>())

                _db.Remove(Id);
        }
        public void UpdateCarMake(CarMake entity)
        {
            using (IDataBusinessService<CarMake> _db = InstanceFactory.GetInstance<IDataBusinessService<CarMake>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region CarTechnicalDetail
        public List<CarTechnicalDetail> GetCarTechnicalDetails()
        {
            using (IDataBusinessService<CarTechnicalDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarTechnicalDetail>>())
            {
                return _db.GetAll();
            }
        }

        public CarTechnicalDetail GetCarTechnicalDetail(int Id)
        {
            using (IDataBusinessService<CarTechnicalDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarTechnicalDetail>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCarTechnicalDetail(CarTechnicalDetail entity)
        {
            using (IDataBusinessService<CarTechnicalDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarTechnicalDetail>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCarTechnicalDetail(int Id)
        {
            using (IDataBusinessService<CarTechnicalDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarTechnicalDetail>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCarTechnicalDetail(CarTechnicalDetail entity)
        {
            using (IDataBusinessService<CarTechnicalDetail> _db = InstanceFactory.GetInstance<IDataBusinessService<CarTechnicalDetail>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region City

        public List<city> GetCities()
        {
            using (IDataBusinessService<city> _db = InstanceFactory.GetInstance<IDataBusinessService<city>>())
            {
                return _db.GetAll();
            }
        }

        public city GetCity(int Id)
        {
            using (IDataBusinessService<city> _db = InstanceFactory.GetInstance<IDataBusinessService<city>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCity(city entity)
        {
            using (IDataBusinessService<city> _db = InstanceFactory.GetInstance<IDataBusinessService<city>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCity(int Id)
        {
            using (IDataBusinessService<city> _db = InstanceFactory.GetInstance<IDataBusinessService<city>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCity(city entity)
        {
            using (IDataBusinessService<city> _db = InstanceFactory.GetInstance<IDataBusinessService<city>>())
            {
                _db.Update(entity);
            }
        }
        #endregion
    }

}
