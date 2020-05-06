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
        public string toplama(int x,int y)
        {
            return string.Format("sonuc {0}",x+y);
        }

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
        public string Getusername(int Id)
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                return _db.GetFilter(x => x.Id == Id).FirstOrDefault().Name.ToString();
            }
        }

        public List<log> GetLogs()
        {
            IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>();
            var result = _db.GetAll();
            return result;
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

        public auction GetAuction(int Id)
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

        #region Claim
        public List<Claim> GetClaims()
        {
            using (IDataBusinessService<Claim> _db = InstanceFactory.GetInstance<IDataBusinessService<Claim>>())
            {
                return _db.GetAll();
            }
        }

        public Claim GetClaim(int Id)
        {
            using (IDataBusinessService<Claim> _db = InstanceFactory.GetInstance<IDataBusinessService<Claim>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddClaim(Claim entity)
        {
            using (IDataBusinessService<Claim> _db = InstanceFactory.GetInstance<IDataBusinessService<Claim>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveClaim(int Id)
        {
            using (IDataBusinessService<Claim> _db = InstanceFactory.GetInstance<IDataBusinessService<Claim>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateClaim(Claim entity)
        {
            using (IDataBusinessService<Claim> _db = InstanceFactory.GetInstance<IDataBusinessService<Claim>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Color
        public List<Color> GetAllColor()
        {
            using (IDataBusinessService<Color> _db = InstanceFactory.GetInstance<IDataBusinessService<Color>>())
            {
                return _db.GetAll();
            }
        }

        public Color GetColor(int Id)
        {
            using (IDataBusinessService<Color> _db = InstanceFactory.GetInstance<IDataBusinessService<Color>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddColor(Color entity)
        {
            using (IDataBusinessService<Color> _db = InstanceFactory.GetInstance<IDataBusinessService<Color>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveColor(int Id)
        {
            using (IDataBusinessService<Color> _db = InstanceFactory.GetInstance<IDataBusinessService<Color>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateColor(Color entity)
        {
            using (IDataBusinessService<Color> _db = InstanceFactory.GetInstance<IDataBusinessService<Color>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Company
        public List<company> GetCompanies()
        {
            using (IDataBusinessService<company> _db = InstanceFactory.GetInstance<IDataBusinessService<company>>())
            {
                return _db.GetAll();
            }
        }

        public company GetCompany(int Id)
        {
            using (IDataBusinessService<company> _db = InstanceFactory.GetInstance<IDataBusinessService<company>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCompany(company entity)
        {
            using (IDataBusinessService<company> _db = InstanceFactory.GetInstance<IDataBusinessService<company>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCompany(int Id)
        {
            using (IDataBusinessService<company> _db = InstanceFactory.GetInstance<IDataBusinessService<company>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCompany(company entity)
        {
            using (IDataBusinessService<company> _db = InstanceFactory.GetInstance<IDataBusinessService<company>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region CompanyTypies
        public List<company_type> GetCompanyTypies()
        {
            using (IDataBusinessService<company_type> _db = InstanceFactory.GetInstance<IDataBusinessService<company_type>>())
            {
                return _db.GetAll();
            }
        }
        public company_type GetCompanyType(int Id)
        {
            using (IDataBusinessService<company_type> _db = InstanceFactory.GetInstance<IDataBusinessService<company_type>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCompanyType(company_type entity)
        {
            using (IDataBusinessService<company_type> _db = InstanceFactory.GetInstance<IDataBusinessService<company_type>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCompanyType(int Id)
        {
            using (IDataBusinessService<company_type> _db = InstanceFactory.GetInstance<IDataBusinessService<company_type>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCompanyType(company_type entity)
        {
            using (IDataBusinessService<company_type> _db = InstanceFactory.GetInstance<IDataBusinessService<company_type>>())
            {
                _db.Update(entity);
            }
        }
        #endregion

        #region Country

        public List<country> GetCountries()
        {
            using (IDataBusinessService<country> _db = InstanceFactory.GetInstance<IDataBusinessService<country>>())
            {
                return _db.GetAll();
            }
        }

        public country GetCountry(int Id)
        {
            using (IDataBusinessService<country> _db = InstanceFactory.GetInstance<IDataBusinessService<country>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCountry(country entity)
        {
            using (IDataBusinessService<country> _db = InstanceFactory.GetInstance<IDataBusinessService<country>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCountry(int Id)
        {
            using (IDataBusinessService<country> _db = InstanceFactory.GetInstance<IDataBusinessService<country>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCountry(country entity)
        {
            using (IDataBusinessService<country> _db = InstanceFactory.GetInstance<IDataBusinessService<country>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region County

        public List<county> GetCounties()
        {
            using (IDataBusinessService<county> _db = InstanceFactory.GetInstance<IDataBusinessService<county>>())
            {
                return _db.GetAll();
            }
        }

        public county GetCounty(int Id)
        {
            using (IDataBusinessService<county> _db = InstanceFactory.GetInstance<IDataBusinessService<county>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCounty(county entity)
        {
            using (IDataBusinessService<county> _db = InstanceFactory.GetInstance<IDataBusinessService<county>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCounty(int Id)
        {
            using (IDataBusinessService<county> _db = InstanceFactory.GetInstance<IDataBusinessService<county>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCounty(county entity)
        {
            using (IDataBusinessService<county> _db = InstanceFactory.GetInstance<IDataBusinessService<county>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region CURRENCY

        public List<CURRENCY> GetCurrencies()
        {
            using (IDataBusinessService<CURRENCY> _db = InstanceFactory.GetInstance<IDataBusinessService<CURRENCY>>())
            {
                return _db.GetAll();
            }
        }

        public CURRENCY GetCurrency(int Id)
        {
            using (IDataBusinessService<CURRENCY> _db = InstanceFactory.GetInstance<IDataBusinessService<CURRENCY>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddCurrency(CURRENCY entity)
        {
            using (IDataBusinessService<CURRENCY> _db = InstanceFactory.GetInstance<IDataBusinessService<CURRENCY>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveCurrency(int Id)
        {
            using (IDataBusinessService<CURRENCY> _db = InstanceFactory.GetInstance<IDataBusinessService<CURRENCY>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateCurrency(CURRENCY entity)
        {
            using (IDataBusinessService<CURRENCY> _db = InstanceFactory.GetInstance<IDataBusinessService<CURRENCY>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region discountcart

        public List<discountcart> GetDiscountcarts()
        {
            using (IDataBusinessService<discountcart> _db = InstanceFactory.GetInstance<IDataBusinessService<discountcart>>())
            {
                return _db.GetAll();
            }
        }

        public discountcart GetDiscountcart(int Id)
        {
            using (IDataBusinessService<discountcart> _db = InstanceFactory.GetInstance<IDataBusinessService<discountcart>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddDiscountcart(discountcart entity)
        {
            using (IDataBusinessService<discountcart> _db = InstanceFactory.GetInstance<IDataBusinessService<discountcart>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveDiscountcart(int Id)
        {
            using (IDataBusinessService<discountcart> _db = InstanceFactory.GetInstance<IDataBusinessService<discountcart>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateDiscountcart(discountcart entity)
        {
            using (IDataBusinessService<discountcart> _db = InstanceFactory.GetInstance<IDataBusinessService<discountcart>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region E_INVOICE
        public List<E_INVOICE> GetE_Invoices()
        {
            using (IDataBusinessService<E_INVOICE> _db = InstanceFactory.GetInstance<IDataBusinessService<E_INVOICE>>())
            {
                return _db.GetAll();
            }
        }

        public E_INVOICE GetE_Invoice(int Id)
        {
            using (IDataBusinessService<E_INVOICE> _db = InstanceFactory.GetInstance<IDataBusinessService<E_INVOICE>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddE_Invoice(E_INVOICE entity)
        {
            using (IDataBusinessService<E_INVOICE> _db = InstanceFactory.GetInstance<IDataBusinessService<E_INVOICE>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveE_Invoice(int Id)
        {
            using (IDataBusinessService<E_INVOICE> _db = InstanceFactory.GetInstance<IDataBusinessService<E_INVOICE>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateE_Invoice(E_INVOICE entity)
        {
            using (IDataBusinessService<E_INVOICE> _db = InstanceFactory.GetInstance<IDataBusinessService<E_INVOICE>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region E_invoice_type

        public List<E_invoice_type> GetE_invoice_types()
        {
            using (IDataBusinessService<E_invoice_type> _db = InstanceFactory.GetInstance<IDataBusinessService<E_invoice_type>>())
            {
                return _db.GetAll();
            }
        }

        public E_invoice_type GetE_invoice_type(int Id)
        {
            using (IDataBusinessService<E_invoice_type> _db = InstanceFactory.GetInstance<IDataBusinessService<E_invoice_type>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddE_invoice_type(E_invoice_type entity)
        {
            using (IDataBusinessService<E_invoice_type> _db = InstanceFactory.GetInstance<IDataBusinessService<E_invoice_type>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveE_invoice_type(int Id)
        {
            using (IDataBusinessService<E_invoice_type> _db = InstanceFactory.GetInstance<IDataBusinessService<E_invoice_type>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateE_invoice_type(E_invoice_type entity)
        {
            using (IDataBusinessService<E_invoice_type> _db = InstanceFactory.GetInstance<IDataBusinessService<E_invoice_type>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region employee
        public List<employee> GetEmployees()
        {
            using (IDataBusinessService<employee> _db = InstanceFactory.GetInstance<IDataBusinessService<employee>>())
            {
                return _db.GetAll();
            }
        }

        public employee GetEmployee(int Id)
        {
            using (IDataBusinessService<employee> _db = InstanceFactory.GetInstance<IDataBusinessService<employee>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddEmployee(employee entity)
        {
            using (IDataBusinessService<employee> _db = InstanceFactory.GetInstance<IDataBusinessService<employee>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveEmployee(int Id)
        {
            using (IDataBusinessService<employee> _db = InstanceFactory.GetInstance<IDataBusinessService<employee>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateEmployee(employee entity)
        {
            using (IDataBusinessService<employee> _db = InstanceFactory.GetInstance<IDataBusinessService<employee>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region employee_position

        public List<employee_position> GetEmployeePositions()
        {
            using (IDataBusinessService<employee_position> _db = InstanceFactory.GetInstance<IDataBusinessService<employee_position>>())
            {
                return _db.GetAll();
            }
        }

        public employee_position GetEmployeePosition(int Id)
        {
            using (IDataBusinessService<employee_position> _db = InstanceFactory.GetInstance<IDataBusinessService<employee_position>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddEmployeePosition(employee_position entity)
        {
            using (IDataBusinessService<employee_position> _db = InstanceFactory.GetInstance<IDataBusinessService<employee_position>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveEmployeePosition(int Id)
        {
            using (IDataBusinessService<employee_position> _db = InstanceFactory.GetInstance<IDataBusinessService<employee_position>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateEmployeePosition(employee_position entity)
        {
            using (IDataBusinessService<employee_position> _db = InstanceFactory.GetInstance<IDataBusinessService<employee_position>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region FuelType

        public List<FuelType> GetFuelTypes()
        {
            using (IDataBusinessService<FuelType> _db = InstanceFactory.GetInstance<IDataBusinessService<FuelType>>())
            {
                return _db.GetAll();
            }
        }

        public FuelType GetFuelType(int Id)
        {
            using (IDataBusinessService<FuelType> _db = InstanceFactory.GetInstance<IDataBusinessService<FuelType>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddFuelType(FuelType entity)
        {
            using (IDataBusinessService<FuelType> _db = InstanceFactory.GetInstance<IDataBusinessService<FuelType>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveFuelType(int Id)
        {
            using (IDataBusinessService<FuelType> _db = InstanceFactory.GetInstance<IDataBusinessService<FuelType>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateFuelType(FuelType entity)
        {
            using (IDataBusinessService<FuelType> _db = InstanceFactory.GetInstance<IDataBusinessService<FuelType>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region GearType

        public List<GearType> GetGearTypes()
        {
            using (IDataBusinessService<GearType> _db = InstanceFactory.GetInstance<IDataBusinessService<GearType>>())
            {
                return _db.GetAll();
            }
        }

        public GearType GetGearType(int Id)
        {
            using (IDataBusinessService<GearType> _db = InstanceFactory.GetInstance<IDataBusinessService<GearType>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddGearType(GearType entity)
        {
            using (IDataBusinessService<GearType> _db = InstanceFactory.GetInstance<IDataBusinessService<GearType>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveGearType(int Id)
        {
            using (IDataBusinessService<GearType> _db = InstanceFactory.GetInstance<IDataBusinessService<GearType>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateGearType(GearType entity)
        {
            using (IDataBusinessService<GearType> _db = InstanceFactory.GetInstance<IDataBusinessService<GearType>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region GeneralDesign

        public List<GeneralDesign> GetGeneralDesignes()
        {
            using (IDataBusinessService<GeneralDesign> _db = InstanceFactory.GetInstance<IDataBusinessService<GeneralDesign>>())
            {
                return _db.GetAll();
            }
        }

        public GeneralDesign GetGeneralDesign(int Id)
        {
            using (IDataBusinessService<GeneralDesign> _db = InstanceFactory.GetInstance<IDataBusinessService<GeneralDesign>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddGeneralDesign(GeneralDesign entity)
        {
            using (IDataBusinessService<GeneralDesign> _db = InstanceFactory.GetInstance<IDataBusinessService<GeneralDesign>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveGeneralDesign(int Id)
        {
            using (IDataBusinessService<GeneralDesign> _db = InstanceFactory.GetInstance<IDataBusinessService<GeneralDesign>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateGeneralDesign(GeneralDesign entity)
        {
            using (IDataBusinessService<GeneralDesign> _db = InstanceFactory.GetInstance<IDataBusinessService<GeneralDesign>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Icon

        public List<Icon> GetIcons()
        {
            using (IDataBusinessService<Icon> _db = InstanceFactory.GetInstance<IDataBusinessService<Icon>>())
            {
                return _db.GetAll();
            }
        }

        public Icon GetIcon(int Id)
        {
            using (IDataBusinessService<Icon> _db = InstanceFactory.GetInstance<IDataBusinessService<Icon>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddIcon(Icon entity)
        {
            using (IDataBusinessService<Icon> _db = InstanceFactory.GetInstance<IDataBusinessService<Icon>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveIcon(int Id)
        {
            using (IDataBusinessService<Icon> _db = InstanceFactory.GetInstance<IDataBusinessService<Icon>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateIcon(Icon entity)
        {
            using (IDataBusinessService<Icon> _db = InstanceFactory.GetInstance<IDataBusinessService<Icon>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Image

        public List<Image> GetImages()
        {
            using (IDataBusinessService<Image> _db = InstanceFactory.GetInstance<IDataBusinessService<Image>>())
            {
                return _db.GetAll();
            }
        }

        public Image GetImage(int Id)
        {
            using (IDataBusinessService<Image> _db = InstanceFactory.GetInstance<IDataBusinessService<Image>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddImage(Image entity)
        {
            using (IDataBusinessService<Image> _db = InstanceFactory.GetInstance<IDataBusinessService<Image>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveImage(int Id)
        {
            using (IDataBusinessService<Image> _db = InstanceFactory.GetInstance<IDataBusinessService<Image>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateImage(Image entity)
        {
            using (IDataBusinessService<Image> _db = InstanceFactory.GetInstance<IDataBusinessService<Image>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Medium

        public List<medium> GetMediums()
        {
            using (IDataBusinessService<medium> _db = InstanceFactory.GetInstance<IDataBusinessService<medium>>())
            {
                return _db.GetAll();
            }
        }

        public medium GetMedium(int Id)
        {
            using (IDataBusinessService<medium> _db = InstanceFactory.GetInstance<IDataBusinessService<medium>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddMedium(medium entity)
        {
            using (IDataBusinessService<medium> _db = InstanceFactory.GetInstance<IDataBusinessService<medium>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveMedium(int Id)
        {
            using (IDataBusinessService<medium> _db = InstanceFactory.GetInstance<IDataBusinessService<medium>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateMedium(medium entity)
        {
            using (IDataBusinessService<medium> _db = InstanceFactory.GetInstance<IDataBusinessService<medium>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Menu

        public List<Menu> GetMenus()
        {
            using (IDataBusinessService<Menu> _db = InstanceFactory.GetInstance<IDataBusinessService<Menu>>())
            {
                return _db.GetAll();
            }
        }

        public Menu GetMenu(int Id)
        {
            using (IDataBusinessService<Menu> _db = InstanceFactory.GetInstance<IDataBusinessService<Menu>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddMenu(Menu entity)
        {
            using (IDataBusinessService<Menu> _db = InstanceFactory.GetInstance<IDataBusinessService<Menu>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveMenu(int Id)
        {
            using (IDataBusinessService<Menu> _db = InstanceFactory.GetInstance<IDataBusinessService<Menu>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateMenu(Menu entity)
        {
            using (IDataBusinessService<Menu> _db = InstanceFactory.GetInstance<IDataBusinessService<Menu>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region natification

        public List<natification> GetNatifications()
        {
            using (IDataBusinessService<natification> _db = InstanceFactory.GetInstance<IDataBusinessService<natification>>())
            {
                return _db.GetAll();
            }
        }

        public natification GetNatification(int Id)
        {
            using (IDataBusinessService<natification> _db = InstanceFactory.GetInstance<IDataBusinessService<natification>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddNatification(natification entity)
        {
            using (IDataBusinessService<natification> _db = InstanceFactory.GetInstance<IDataBusinessService<natification>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveNatification(int Id)
        {
            using (IDataBusinessService<natification> _db = InstanceFactory.GetInstance<IDataBusinessService<natification>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateNatification(natification entity)
        {
            using (IDataBusinessService<natification> _db = InstanceFactory.GetInstance<IDataBusinessService<natification>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region odeme_yontemi

        public List<odeme_yontemi> Getodeme_yontemleri()
        {
            using (IDataBusinessService<odeme_yontemi> _db = InstanceFactory.GetInstance<IDataBusinessService<odeme_yontemi>>())
            {
                return _db.GetAll();
            }
        }

        public odeme_yontemi GetOdemeYontemi(int Id)
        {
            using (IDataBusinessService<odeme_yontemi> _db = InstanceFactory.GetInstance<IDataBusinessService<odeme_yontemi>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddOdemeYontemi(odeme_yontemi entity)
        {
            using (IDataBusinessService<odeme_yontemi> _db = InstanceFactory.GetInstance<IDataBusinessService<odeme_yontemi>>())
            {
                 _db.Add(entity);
            }
        }

        public void RemoveOdemeYontemi(int Id)
        {
            using (IDataBusinessService<odeme_yontemi> _db = InstanceFactory.GetInstance<IDataBusinessService<odeme_yontemi>>())
            {
                 _db.Remove(Id);
            }
        }

        public void UpdateOdemeYontemi(odeme_yontemi entity)
        {
            using (IDataBusinessService<odeme_yontemi> _db = InstanceFactory.GetInstance<IDataBusinessService<odeme_yontemi>>())
            {
                 _db.Update(entity);
            }
        }

        #endregion

        #region payment_plan

        public List<payment_plan> GetPaymentPlans()
        {
            using (IDataBusinessService<payment_plan> _db = InstanceFactory.GetInstance<IDataBusinessService<payment_plan>>())
            {
                return _db.GetAll();
            }
        }

        public payment_plan GetPaymentPlan(int Id)
        {
            using (IDataBusinessService<payment_plan> _db = InstanceFactory.GetInstance<IDataBusinessService<payment_plan>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddPaymentPlan(payment_plan entity)
        {
            using (IDataBusinessService<payment_plan> _db = InstanceFactory.GetInstance<IDataBusinessService<payment_plan>>())
            {
                _db.Add(entity);
            }
        }

        public void RemovePaymentPlan(int Id)
        {
            using (IDataBusinessService<payment_plan> _db = InstanceFactory.GetInstance<IDataBusinessService<payment_plan>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdatePaymentPlan(payment_plan entity)
        {
            using (IDataBusinessService<payment_plan> _db = InstanceFactory.GetInstance<IDataBusinessService<payment_plan>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Post

        public List<Post> GetPosts()
        {
            using (IDataBusinessService<Post> _db = InstanceFactory.GetInstance<IDataBusinessService<Post>>())
            {
                return _db.GetAll();
            }
        }

        public Post GetPost(int Id)
        {
            using (IDataBusinessService<Post> _db = InstanceFactory.GetInstance<IDataBusinessService<Post>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddPost(Post entity)
        {
            using (IDataBusinessService<Post> _db = InstanceFactory.GetInstance<IDataBusinessService<Post>>())
            {
                _db.Add(entity);
            }
        }

        public void RemovePost(int Id)
        {
            using (IDataBusinessService<Post> _db = InstanceFactory.GetInstance<IDataBusinessService<Post>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdatePost(Post entity)
        {
            using (IDataBusinessService<Post> _db = InstanceFactory.GetInstance<IDataBusinessService<Post>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region PRICEBOT

        public List<PRICEBOT> GetPricebots()
        {
            using (IDataBusinessService<PRICEBOT> _db = InstanceFactory.GetInstance<IDataBusinessService<PRICEBOT>>())
            {
                return _db.GetAll();
            }
        }

        public PRICEBOT GetPricebot(int Id)
        {
            using (IDataBusinessService<PRICEBOT> _db = InstanceFactory.GetInstance<IDataBusinessService<PRICEBOT>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddPricebot(PRICEBOT entity)
        {
            using (IDataBusinessService<PRICEBOT> _db = InstanceFactory.GetInstance<IDataBusinessService<PRICEBOT>>())
            {
                _db.Add(entity);
            }
        }

        public void RemovePricebot(int Id)
        {
            using (IDataBusinessService<PRICEBOT> _db = InstanceFactory.GetInstance<IDataBusinessService<PRICEBOT>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdatePricebot(PRICEBOT entity)
        {
            using (IDataBusinessService<PRICEBOT> _db = InstanceFactory.GetInstance<IDataBusinessService<PRICEBOT>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Role

        public List<Role> GetRoles()
        {
            using (IDataBusinessService<Role> _db = InstanceFactory.GetInstance<IDataBusinessService<Role>>())
            {
                return _db.GetAll();
            }
        }

        public Role GetRole(int Id)
        {
            using (IDataBusinessService<Role> _db = InstanceFactory.GetInstance<IDataBusinessService<Role>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddRole(Role entity)
        {
            using (IDataBusinessService<Role> _db = InstanceFactory.GetInstance<IDataBusinessService<Role>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveRole(int Id)
        {
            using (IDataBusinessService<Role> _db = InstanceFactory.GetInstance<IDataBusinessService<Role>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateRole(Role entity)
        {
            using (IDataBusinessService<Role> _db = InstanceFactory.GetInstance<IDataBusinessService<Role>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region RoleClaim

        public List<RoleClaim> GetRoleClaims()
        {
            using (IDataBusinessService<RoleClaim> _db = InstanceFactory.GetInstance<IDataBusinessService<RoleClaim>>())
            {
                return _db.GetAll();
            }
        }

        public RoleClaim GetRoleClaim(int Id)
        {
            using (IDataBusinessService<RoleClaim> _db = InstanceFactory.GetInstance<IDataBusinessService<RoleClaim>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddRoleClaim(RoleClaim entity)
        {
            using (IDataBusinessService<RoleClaim> _db = InstanceFactory.GetInstance<IDataBusinessService<RoleClaim>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveRoleClaim(int Id)
        {
            using (IDataBusinessService<RoleClaim> _db = InstanceFactory.GetInstance<IDataBusinessService<RoleClaim>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateRoleClaim(RoleClaim entity)
        {
            using (IDataBusinessService<RoleClaim> _db = InstanceFactory.GetInstance<IDataBusinessService<RoleClaim>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Segment
        public List<Segment> GetSegments()
        {
            using (IDataBusinessService<Segment> _db = InstanceFactory.GetInstance<IDataBusinessService<Segment>>())
            {
                return _db.GetAll();
            }
        }

        public Segment GetSegment(int Id)
        {
            using (IDataBusinessService<Segment> _db = InstanceFactory.GetInstance<IDataBusinessService<Segment>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSegment(Segment entity)
        {
            using (IDataBusinessService<Segment> _db = InstanceFactory.GetInstance<IDataBusinessService<Segment>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSegment(int Id)
        {
            using (IDataBusinessService<Segment> _db = InstanceFactory.GetInstance<IDataBusinessService<Segment>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSegment(Segment entity)
        {
            using (IDataBusinessService<Segment> _db = InstanceFactory.GetInstance<IDataBusinessService<Segment>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region senaryo


        public List<senaryo> GetSenarios()
        {
            using (IDataBusinessService<senaryo> _db = InstanceFactory.GetInstance<IDataBusinessService<senaryo>>())
            {
                return _db.GetAll();
            }
        }

        public senaryo GetSenario(int Id)
        {
            using (IDataBusinessService<senaryo> _db = InstanceFactory.GetInstance<IDataBusinessService<senaryo>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSenario(senaryo entity)
        {
            using (IDataBusinessService<senaryo> _db = InstanceFactory.GetInstance<IDataBusinessService<senaryo>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSenario(int Id)
        {
            using (IDataBusinessService<senaryo> _db = InstanceFactory.GetInstance<IDataBusinessService<senaryo>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSenario(senaryo entity)
        {
            using (IDataBusinessService<senaryo> _db = InstanceFactory.GetInstance<IDataBusinessService<senaryo>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region SocialMedya


        public List<SocialMedya> GetSocialMedias()
        {
            using (IDataBusinessService<SocialMedya> _db = InstanceFactory.GetInstance<IDataBusinessService<SocialMedya>>())
            {
                return _db.GetAll();
            }
        }

        public SocialMedya GetSocialMedia(int Id)
        {
            using (IDataBusinessService<SocialMedya> _db = InstanceFactory.GetInstance<IDataBusinessService<SocialMedya>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSocialMedia(SocialMedya entity)
        {
            using (IDataBusinessService<SocialMedya> _db = InstanceFactory.GetInstance<IDataBusinessService<SocialMedya>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSocialMedia(int Id)
        {
            using (IDataBusinessService<SocialMedya> _db = InstanceFactory.GetInstance<IDataBusinessService<SocialMedya>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSocialMedia(SocialMedya entity)
        {
            using (IDataBusinessService<SocialMedya> _db = InstanceFactory.GetInstance<IDataBusinessService<SocialMedya>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region SOLD_PRODUCT

        public List<SOLD_PRODUCT> GetSoldProducts()
        {
            using (IDataBusinessService<SOLD_PRODUCT> _db = InstanceFactory.GetInstance<IDataBusinessService<SOLD_PRODUCT>>())
            {
                return _db.GetAll();
            }
        }

        public SOLD_PRODUCT GetSoldProduct(int Id)
        {
            using (IDataBusinessService<SOLD_PRODUCT> _db = InstanceFactory.GetInstance<IDataBusinessService<SOLD_PRODUCT>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSoldProduct(SOLD_PRODUCT entity)
        {
            using (IDataBusinessService<SOLD_PRODUCT> _db = InstanceFactory.GetInstance<IDataBusinessService<SOLD_PRODUCT>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSoldProduct(int Id)
        {
            using (IDataBusinessService<SOLD_PRODUCT> _db = InstanceFactory.GetInstance<IDataBusinessService<SOLD_PRODUCT>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSoldProduct(SOLD_PRODUCT entity)
        {
            using (IDataBusinessService<SOLD_PRODUCT> _db = InstanceFactory.GetInstance<IDataBusinessService<SOLD_PRODUCT>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region submit

        public List<submit> GetSubmits()
        {
            using (IDataBusinessService<submit> _db = InstanceFactory.GetInstance<IDataBusinessService<submit>>())
            {
                return _db.GetAll();
            }
        }

        public submit GetSubmit(int Id)
        {
            using (IDataBusinessService<submit> _db = InstanceFactory.GetInstance<IDataBusinessService<submit>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSubmit(submit entity)
        {
            using (IDataBusinessService<submit> _db = InstanceFactory.GetInstance<IDataBusinessService<submit>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSubmit(int Id)
        {
            using (IDataBusinessService<submit> _db = InstanceFactory.GetInstance<IDataBusinessService<submit>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSubmit(submit entity)
        {
            using (IDataBusinessService<submit> _db = InstanceFactory.GetInstance<IDataBusinessService<submit>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region sysdiagram

        public List<sysdiagram> GetSysdiagrams()
        {
            using (IDataBusinessService<sysdiagram> _db = InstanceFactory.GetInstance<IDataBusinessService<sysdiagram>>())
            {
                return _db.GetAll();
            }
        }

        public sysdiagram GetSysdiagram(int Id)
        {
            using (IDataBusinessService<sysdiagram> _db = InstanceFactory.GetInstance<IDataBusinessService<sysdiagram>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddSysdiagram(sysdiagram entity)
        {
            using (IDataBusinessService<sysdiagram> _db = InstanceFactory.GetInstance<IDataBusinessService<sysdiagram>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveSysdiagram(int Id)
        {
            using (IDataBusinessService<sysdiagram> _db = InstanceFactory.GetInstance<IDataBusinessService<sysdiagram>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateSysdiagram(sysdiagram entity)
        {
            using (IDataBusinessService<sysdiagram> _db = InstanceFactory.GetInstance<IDataBusinessService<sysdiagram>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region tag

        public List<tag> GetTags()
        {
            using (IDataBusinessService<tag> _db = InstanceFactory.GetInstance<IDataBusinessService<tag>>())
            {
                return _db.GetAll();
            }
        }

        public tag GetTag(int Id)
        {
            using (IDataBusinessService<tag> _db = InstanceFactory.GetInstance<IDataBusinessService<tag>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddTag(tag entity)
        {
            using (IDataBusinessService<tag> _db = InstanceFactory.GetInstance<IDataBusinessService<tag>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveTag(int Id)
        {
            using (IDataBusinessService<tag> _db = InstanceFactory.GetInstance<IDataBusinessService<tag>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateTag(tag entity)
        {
            using (IDataBusinessService<tag> _db = InstanceFactory.GetInstance<IDataBusinessService<tag>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region tag_post

        public List<tag_post> GetTagPosts()
        {
            using (IDataBusinessService<tag_post> _db = InstanceFactory.GetInstance<IDataBusinessService<tag_post>>())
            {
                return _db.GetAll();
            }
        }

        public tag_post GetTagPost(int Id)
        {
            using (IDataBusinessService<tag_post> _db = InstanceFactory.GetInstance<IDataBusinessService<tag_post>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddTagPost(tag_post entity)
        {
            using (IDataBusinessService<tag_post> _db = InstanceFactory.GetInstance<IDataBusinessService<tag_post>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveTagPost(int Id)
        {
            using (IDataBusinessService<tag_post> _db = InstanceFactory.GetInstance<IDataBusinessService<tag_post>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateTagPost(tag_post entity)
        {
            using (IDataBusinessService<tag_post> _db = InstanceFactory.GetInstance<IDataBusinessService<tag_post>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region Tax_Administration

        public List<Tax_Administration> GetTax_Administrations()
        {
            using (IDataBusinessService<Tax_Administration> _db = InstanceFactory.GetInstance<IDataBusinessService<Tax_Administration>>())
            {
                return _db.GetAll();
            }
        }

        public Tax_Administration GetTax_Administration(int Id)
        {
            using (IDataBusinessService<Tax_Administration> _db = InstanceFactory.GetInstance<IDataBusinessService<Tax_Administration>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddTax_Administration(Tax_Administration entity)
        {
            using (IDataBusinessService<Tax_Administration> _db = InstanceFactory.GetInstance<IDataBusinessService<Tax_Administration>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveTax_Administration(int Id)
        {
            using (IDataBusinessService<Tax_Administration> _db = InstanceFactory.GetInstance<IDataBusinessService<Tax_Administration>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateTax_Administration(Tax_Administration entity)
        {
            using (IDataBusinessService<Tax_Administration> _db = InstanceFactory.GetInstance<IDataBusinessService<Tax_Administration>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region title

        public List<title> GetTitles()
        {
            using (IDataBusinessService<title> _db = InstanceFactory.GetInstance<IDataBusinessService<title>>())
            {
                return _db.GetAll();
            }
        }

        public title GetTitle(int Id)
        {
            using (IDataBusinessService<title> _db = InstanceFactory.GetInstance<IDataBusinessService<title>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddTitle(title entity)
        {
            using (IDataBusinessService<title> _db = InstanceFactory.GetInstance<IDataBusinessService<title>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveTitle(int Id)
        {
            using (IDataBusinessService<title> _db = InstanceFactory.GetInstance<IDataBusinessService<title>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateTitle(title entity)
        {
            using (IDataBusinessService<title> _db = InstanceFactory.GetInstance<IDataBusinessService<title>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region User

        public List<User> GetUsers()
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                return _db.GetAll();
            }
        }

        public User GetUser(int Id)
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddUser(User entity)
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveUser(int Id)
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateUser(User entity)
        {
            using (IDataBusinessService<User> _db = InstanceFactory.GetInstance<IDataBusinessService<User>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region UserRole

        public List<UserRole> GetUserRoles()
        {
            using (IDataBusinessService<UserRole> _db = InstanceFactory.GetInstance<IDataBusinessService<UserRole>>())
            {
                return _db.GetAll();
            }
        }

        public UserRole GetUserRole(int Id)
        {
            using (IDataBusinessService<UserRole> _db = InstanceFactory.GetInstance<IDataBusinessService<UserRole>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddUserRole(UserRole entity)
        {
            using (IDataBusinessService<UserRole> _db = InstanceFactory.GetInstance<IDataBusinessService<UserRole>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveUserRole(int Id)
        {
            using (IDataBusinessService<UserRole> _db = InstanceFactory.GetInstance<IDataBusinessService<UserRole>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateUserRole(UserRole entity)
        {
            using (IDataBusinessService<UserRole> _db = InstanceFactory.GetInstance<IDataBusinessService<UserRole>>())
            {
                _db.Update(entity);
            }
        }

        #endregion

        #region UserType

        public List<UserType> GetUserTypes()
        {
            using (IDataBusinessService<UserType> _db = InstanceFactory.GetInstance<IDataBusinessService<UserType>>())
            {
                return _db.GetAll();
            }
        }

        public UserType GetUserType(int Id)
        {
            using (IDataBusinessService<UserType> _db = InstanceFactory.GetInstance<IDataBusinessService<UserType>>())
            {
                return _db.Get(Id);
            }
        }

        public void AddUserType(UserType entity)
        {
            using (IDataBusinessService<UserType> _db = InstanceFactory.GetInstance<IDataBusinessService<UserType>>())
            {
                _db.Add(entity);
            }
        }

        public void RemoveUserType(int Id)
        {
            using (IDataBusinessService<UserType> _db = InstanceFactory.GetInstance<IDataBusinessService<UserType>>())
            {
                _db.Remove(Id);
            }
        }

        public void UpdateUserType(UserType entity)
        {
            using (IDataBusinessService<UserType> _db = InstanceFactory.GetInstance<IDataBusinessService<UserType>>())
            {
                _db.Update(entity);
            }
        }
        #endregion

        public List<actionuser> Getactionusers()
        {
            using (IDataBusinessService<actionuser> _db = InstanceFactory.GetInstance<IDataBusinessService<actionuser>>())
            {
                return _db.GetAll();
            }
        }

        public actionuser Getactionuser(int Id)
        {
            using (IDataBusinessService<actionuser> _db = InstanceFactory.GetInstance<IDataBusinessService<actionuser>>())
            {
                return _db.Get(Id);
            }
        }

        public void Addactionuser(actionuser entity)
        {
            using (IDataBusinessService<actionuser> _db = InstanceFactory.GetInstance<IDataBusinessService<actionuser>>())
            {
                _db.Add(entity);
            }
        }

        public void Removeactionuser(int Id)
        {
            using (IDataBusinessService<actionuser> _db = InstanceFactory.GetInstance<IDataBusinessService<actionuser>>())
            {
                _db.Remove(Id);
            }
        }

        public void Updateactionuser(actionuser entity)
        {
            using (IDataBusinessService<actionuser> _db = InstanceFactory.GetInstance<IDataBusinessService<actionuser>>())
            {
                _db.Update(entity);
            }
        }

        public List<private_auction> Getprivateauctions()
        {
            using (IDataBusinessService<private_auction> _db = InstanceFactory.GetInstance<IDataBusinessService<private_auction>>())
            {
                return _db.GetAll();
            }
        }

        public private_auction Getprivateauction(int Id)
        {
            using (IDataBusinessService<private_auction> _db = InstanceFactory.GetInstance<IDataBusinessService<private_auction>>())
            {
                return _db.Get(Id);
            }
        }

        public void Addprivateauction(private_auction entity)
        {
            using (IDataBusinessService<private_auction> _db = InstanceFactory.GetInstance<IDataBusinessService<private_auction>>())
            {
                _db.Add(entity);
            }
        }

        public void Removeprivateauction(int Id)
        {
            using (IDataBusinessService<private_auction> _db = InstanceFactory.GetInstance<IDataBusinessService<private_auction>>())
            {
                _db.Remove(Id);
            }
        }

        public void Updateprivateauction(private_auction entity)
        {
            using (IDataBusinessService<private_auction> _db = InstanceFactory.GetInstance<IDataBusinessService<private_auction>>())
            {
                _db.Update(entity);
            }
        }

        public List<userproduct> Getuserproducts()
        {
            using (IDataBusinessService<userproduct> _db = InstanceFactory.GetInstance<IDataBusinessService<userproduct>>())
            {
                return _db.GetAll();
            }
        }

        public userproduct Getuserproduct(int Id)
        {
            using (IDataBusinessService<userproduct> _db = InstanceFactory.GetInstance<IDataBusinessService<userproduct>>())
            {
                return _db.Get(Id);
            }
        }

        public void Adduserproduct(userproduct entity)
        {
            using (IDataBusinessService<userproduct> _db = InstanceFactory.GetInstance<IDataBusinessService<userproduct>>())
            {
                _db.Add(entity);
            }
        }

        public void Removeuserproduct(int Id)
        {
            using (IDataBusinessService<userproduct> _db = InstanceFactory.GetInstance<IDataBusinessService<userproduct>>())
            {
                _db.Remove(Id);
            }
        }

        public void Updateuserproduct(userproduct entity)
        {
            using (IDataBusinessService<userproduct> _db = InstanceFactory.GetInstance<IDataBusinessService<userproduct>>())
            {
                _db.Update(entity);
            }
        }
    }

}
