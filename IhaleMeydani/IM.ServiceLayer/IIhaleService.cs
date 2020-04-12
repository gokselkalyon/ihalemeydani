using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IM.ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIhaleService" in both code and config file together.
    [ServiceContract]
    public interface IIhaleService
    {
        #region log
        [OperationContract]
        List<log> GetLogs();

        [OperationContract]
        log GetLog(int Id);

        [OperationContract]
        void AddLog(log entity);

        [OperationContract]
        void RemoveLog(int Id);

        [OperationContract]
        void UpdateLog(log entity);
        #endregion

        #region AMOUNT_OF_INCREASE
        [OperationContract]
        List<AMOUNT_OF_INCREASE> GetsAmountofIncrease();

        [OperationContract]
        AMOUNT_OF_INCREASE GetAmountofIncrease(int Id);

        [OperationContract]
        void AddAmountofIncrease(AMOUNT_OF_INCREASE entity);

        [OperationContract]
        void RemoveAmountofIncrease(int Id);

        [OperationContract]
        void UpdateAmountofIncrease(AMOUNT_OF_INCREASE entity);
        #endregion

        #region auction
        [OperationContract]
        List<auction> GetAuctions();

        [OperationContract]
        auction GetAuction(int Id);

        [OperationContract]
        void AddAuction(auction entity);

        [OperationContract]
        void RemoveAuction(int Id);

        [OperationContract]
        void UpdateAuction(auction entity);
        #endregion

        #region bank
        [OperationContract]
        List<bank> GetBanks();

        [OperationContract]
        bank GetBank(int Id);

        [OperationContract]
        void AddBank(bank entity);

        [OperationContract]
        void RemoveBank(int Id);

        [OperationContract]
        void UpdateBank(bank entity);
        #endregion

        #region CarBrand
        [OperationContract]
        List<CarBrand> GetCarBrands();

        [OperationContract]
        CarBrand GetCarBrand(int Id);

        [OperationContract]
        void AddCarBrand(CarBrand entity);

        [OperationContract]
        void RemoveCarBrand(int Id);

        [OperationContract]
        void UpdateCarBrand(CarBrand entity);
        #endregion

        #region CarDetail
        [OperationContract]
        List<CarDetail> GetCarDetails();

        [OperationContract]
        CarDetail GetCarDetail(int Id);

        [OperationContract]
        void AddCarDetail(CarDetail entity);

        [OperationContract]
        void RemoveCarDetail(int Id);

        [OperationContract]
        void UpdateCarDetail(CarDetail entity);
        #endregion

        #region CarHardwareDetail
        [OperationContract]
        List<CarHardwareDetail> GetCarHardwareDetails();

        [OperationContract]
        CarHardwareDetail GetCarHardwareDetail(int Id);

        [OperationContract]
        void AddCarHardwareDetail(CarHardwareDetail entity);

        [OperationContract]
        void RemoveCarHardwareDetail(int Id);

        [OperationContract]
        void UpdateCarHardwareDetail(CarHardwareDetail entity);
        #endregion

        #region CarMake
        [OperationContract]
        List<CarMake> GetCarMakes();

        [OperationContract]
        CarMake GetCarMake(int Id);

        [OperationContract]
        void AddCarMake(CarMake entity);

        [OperationContract]
        void RemoveCarMake(int Id);

        [OperationContract]
        void UpdateCarMake(CarMake entity);
        #endregion

        #region CarTechnicalDetail
        [OperationContract]
        List<CarTechnicalDetail> GetCarTechnicalDetails();

        [OperationContract]
        CarTechnicalDetail GetCarTechnicalDetail(int Id);

        [OperationContract]
        void AddCarTechnicalDetail(CarTechnicalDetail entity);

        [OperationContract]
        void RemoveCarTechnicalDetail(int Id);

        [OperationContract]
        void UpdateCarTechnicalDetail(CarTechnicalDetail entity);
        #endregion

        #region city
        [OperationContract]
        List<city> GetCities();

        [OperationContract]
        city GetCity(int Id);

        [OperationContract]
        void AddCity(city entity);

        [OperationContract]
        void RemoveCity(int Id);

        [OperationContract]
        void UpdateCity(city entity);
        #endregion

    }
}
