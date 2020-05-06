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
        [OperationContract]
        string toplama(int x ,int y);

        #region userproduct
        [OperationContract]
        List<userproduct> Getuserproducts();

        [OperationContract]
        userproduct Getuserproduct(int Id);

        [OperationContract]
        void Adduserproduct(userproduct entity);

        [OperationContract]
        void Removeuserproduct(int Id);

        [OperationContract]
        void Updateuserproduct(userproduct entity);
        #endregion


        #region auctionuser
        [OperationContract]
        List<actionuser> Getactionusers();

        [OperationContract]
        actionuser Getactionuser(int Id);

        [OperationContract]
        void Addactionuser(actionuser entity);

        [OperationContract]
        void Removeactionuser(int Id);

        [OperationContract]
        void Updateactionuser(actionuser entity);
        #endregion

        #region privateauction
        [OperationContract]
        List<private_auction> Getprivateauctions();

        [OperationContract]
        private_auction Getprivateauction(int Id);

        [OperationContract]
        void Addprivateauction(private_auction entity);

        [OperationContract]
        void Removeprivateauction(int Id);

        [OperationContract]
        void Updateprivateauction(private_auction entity);
        #endregion

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

        #region Claim
        [OperationContract]
        List<Claim> GetClaims();

        [OperationContract]
        Claim GetClaim(int Id);

        [OperationContract]
        void AddClaim(Claim entity);

        [OperationContract]
        void RemoveClaim(int Id);

        [OperationContract]
        void UpdateClaim(Claim entity);
        #endregion

        #region Color
        [OperationContract]
        List<Color> GetAllColor();

        [OperationContract]
        Color GetColor(int Id);

        [OperationContract]
        void AddColor(Color entity);

        [OperationContract]
        void RemoveColor(int Id);

        [OperationContract]
        void UpdateColor(Color entity);
        #endregion

        #region Company
        [OperationContract]
        List<company> GetCompanies();

        [OperationContract]
        company GetCompany(int Id);

        [OperationContract]
        void AddCompany(company entity);

        [OperationContract]
        void RemoveCompany(int Id);

        [OperationContract]
        void UpdateCompany(company entity);
        #endregion

        #region company_type
        [OperationContract]
        List<company_type> GetCompanyTypies();

        [OperationContract]
        company_type GetCompanyType(int Id);

        [OperationContract]
        void AddCompanyType(company_type entity);

        [OperationContract]
        void RemoveCompanyType(int Id);

        [OperationContract]
        void UpdateCompanyType(company_type entity);
        #endregion

        #region Country
        [OperationContract]
        List<country> GetCountries();

        [OperationContract]
        country GetCountry(int Id);

        [OperationContract]
        void AddCountry(country entity);

        [OperationContract]
        void RemoveCountry(int Id);

        [OperationContract]
        void UpdateCountry(country entity);
        #endregion

        #region County
        [OperationContract]
        List<county> GetCounties();

        [OperationContract]
        county GetCounty(int Id);

        [OperationContract]
        void AddCounty(county entity);

        [OperationContract]
        void RemoveCounty(int Id);

        [OperationContract]
        void UpdateCounty(county entity);
        #endregion

        #region CURRENCY
        [OperationContract]
        List<CURRENCY> GetCurrencies();

        [OperationContract]
        CURRENCY GetCurrency(int Id);

        [OperationContract]
        void AddCurrency(CURRENCY entity);

        [OperationContract]
        void RemoveCurrency(int Id);

        [OperationContract]
        void UpdateCurrency(CURRENCY entity);
        #endregion

        #region Discountcart
        [OperationContract]
        List<discountcart> GetDiscountcarts();

        [OperationContract]
        discountcart GetDiscountcart(int Id);

        [OperationContract]
        void AddDiscountcart(discountcart entity);

        [OperationContract]
        void RemoveDiscountcart(int Id);

        [OperationContract]
        void UpdateDiscountcart(discountcart entity);
        #endregion

        #region E_INVOICE
        [OperationContract]
        List<E_INVOICE> GetE_Invoices();

        [OperationContract]
        E_INVOICE GetE_Invoice(int Id);

        [OperationContract]
        void AddE_Invoice(E_INVOICE entity);

        [OperationContract]
        void RemoveE_Invoice(int Id);

        [OperationContract]
        void UpdateE_Invoice(E_INVOICE entity);
        #endregion

        #region E_invoice_type
        [OperationContract]
        List<E_invoice_type> GetE_invoice_types();

        [OperationContract]
        E_invoice_type GetE_invoice_type(int Id);

        [OperationContract]
        void AddE_invoice_type(E_invoice_type entity);

        [OperationContract]
        void RemoveE_invoice_type(int Id);

        [OperationContract]
        void UpdateE_invoice_type(E_invoice_type entity);
        #endregion


        #region employee
        [OperationContract]
        List<employee> GetEmployees();

        [OperationContract]
        employee GetEmployee(int Id);

        [OperationContract]
        void AddEmployee(employee entity);

        [OperationContract]
        void RemoveEmployee(int Id);

        [OperationContract]
        void UpdateEmployee(employee entity);
        #endregion


        #region FuelType
        [OperationContract]
        List<FuelType> GetFuelTypes();

        [OperationContract]
        FuelType GetFuelType(int Id);

        [OperationContract]
        void AddFuelType(FuelType entity);

        [OperationContract]
        void RemoveFuelType(int Id);

        [OperationContract]
        void UpdateFuelType(FuelType entity);
        #endregion

        #region GearType
        [OperationContract]
        List<GearType> GetGearTypes();

        [OperationContract]
        GearType GetGearType(int Id);

        [OperationContract]
        void AddGearType(GearType entity);

        [OperationContract]
        void RemoveGearType(int Id);

        [OperationContract]
        void UpdateGearType(GearType entity);
        #endregion

        #region GeneralDesign
        [OperationContract]
        List<GeneralDesign> GetGeneralDesignes();

        [OperationContract]
        GeneralDesign GetGeneralDesign(int Id);

        [OperationContract]
        void AddGeneralDesign(GeneralDesign entity);

        [OperationContract]
        void RemoveGeneralDesign(int Id);

        [OperationContract]
        void UpdateGeneralDesign(GeneralDesign entity);
        #endregion

        #region Icon
        [OperationContract]
        List<Icon> GetIcons();

        [OperationContract]
        Icon GetIcon(int Id);

        [OperationContract]
        void AddIcon(Icon entity);

        [OperationContract]
        void RemoveIcon(int Id);

        [OperationContract]
        void UpdateIcon(Icon entity);
        #endregion

        #region Image
        [OperationContract]
        List<Image> GetImages();

        [OperationContract]
        Image GetImage(int Id);

        [OperationContract]
        void AddImage(Image entity);

        [OperationContract]
        void RemoveImage(int Id);

        [OperationContract]
        void UpdateImage(Image entity);
        #endregion

        #region medium
        [OperationContract]
        List<medium> GetMediums();

        [OperationContract]
        medium GetMedium(int Id);

        [OperationContract]
        void AddMedium(medium entity);

        [OperationContract]
        void RemoveMedium(int Id);

        [OperationContract]
        void UpdateMedium(medium entity);
        #endregion

        #region Menu
        [OperationContract]
        List<Menu> GetMenus();

        [OperationContract]
        Menu GetMenu(int Id);

        [OperationContract]
        void AddMenu(Menu entity);

        [OperationContract]
        void RemoveMenu(int Id);

        [OperationContract]
        void UpdateMenu(Menu entity);
        #endregion

        #region natification
        [OperationContract]
        List<natification> GetNatifications();

        [OperationContract]
        natification GetNatification(int Id);

        [OperationContract]
        void AddNatification(natification entity);

        [OperationContract]
        void RemoveNatification(int Id);

        [OperationContract]
        void UpdateNatification(natification entity);
        #endregion

        #region odeme_yontemi
        [OperationContract]
        List<odeme_yontemi> Getodeme_yontemleri();

        [OperationContract]
        odeme_yontemi GetOdemeYontemi(int Id);

        [OperationContract]
        void AddOdemeYontemi(odeme_yontemi entity);

        [OperationContract]
        void RemoveOdemeYontemi(int Id);

        [OperationContract]
        void UpdateOdemeYontemi(odeme_yontemi entity);
        #endregion

        #region payment_plan
        [OperationContract]
        List<payment_plan> GetPaymentPlans();

        [OperationContract]
        payment_plan GetPaymentPlan(int Id);

        [OperationContract]
        void AddPaymentPlan(payment_plan entity);

        [OperationContract]
        void RemovePaymentPlan(int Id);

        [OperationContract]
        void UpdatePaymentPlan(payment_plan entity);
        #endregion

        #region Post
        [OperationContract]
        List<Post> GetPosts();

        [OperationContract]
        Post GetPost(int Id);

        [OperationContract]
        void AddPost(Post entity);

        [OperationContract]
        void RemovePost(int Id);

        [OperationContract]
        void UpdatePost(Post entity);
        #endregion

        #region PRICEBOT
        [OperationContract]
        List<PRICEBOT> GetPricebots();

        [OperationContract]
        PRICEBOT GetPricebot(int Id);

        [OperationContract]
        void AddPricebot(PRICEBOT entity);

        [OperationContract]
        void RemovePricebot(int Id);

        [OperationContract]
        void UpdatePricebot(PRICEBOT entity);
        #endregion

        #region Role
        [OperationContract]
        List<Role> GetRoles();

        [OperationContract]
        Role GetRole(int Id);

        [OperationContract]
        void AddRole(Role entity);

        [OperationContract]
        void RemoveRole(int Id);

        [OperationContract]
        void UpdateRole(Role entity);
        #endregion

        #region RoleClaim
        [OperationContract]
        List<RoleClaim> GetRoleClaims();

        [OperationContract]
        RoleClaim GetRoleClaim(int Id);

        [OperationContract]
        void AddRoleClaim(RoleClaim entity);

        [OperationContract]
        void RemoveRoleClaim(int Id);

        [OperationContract]
        void UpdateRoleClaim(RoleClaim entity);
        #endregion

        #region Segment
        [OperationContract]
        List<Segment> GetSegments();

        [OperationContract]
        Segment GetSegment(int Id);

        [OperationContract]
        void AddSegment(Segment entity);

        [OperationContract]
        void RemoveSegment(int Id);

        [OperationContract]
        void UpdateSegment(Segment entity);
        #endregion

        #region senaryo
        [OperationContract]
        List<senaryo> GetSenarios();

        [OperationContract]
        senaryo GetSenario(int Id);

        [OperationContract]
        void AddSenario(senaryo entity);

        [OperationContract]
        void RemoveSenario(int Id);

        [OperationContract]
        void UpdateSenario(senaryo entity);
        #endregion

        #region SocialMedya
        [OperationContract]
        List<SocialMedya> GetSocialMedias();

        [OperationContract]
        SocialMedya GetSocialMedia(int Id);

        [OperationContract]
        void AddSocialMedia(SocialMedya entity);

        [OperationContract]
        void RemoveSocialMedia(int Id);

        [OperationContract]
        void UpdateSocialMedia(SocialMedya entity);
        #endregion

        #region SOLD_PRODUCT
        [OperationContract]
        List<SOLD_PRODUCT> GetSoldProducts();

        [OperationContract]
        SOLD_PRODUCT GetSoldProduct(int Id);

        [OperationContract]
        void AddSoldProduct(SOLD_PRODUCT entity);

        [OperationContract]
        void RemoveSoldProduct(int Id);

        [OperationContract]
        void UpdateSoldProduct(SOLD_PRODUCT entity);

        #endregion

        #region submit
        [OperationContract]
        List<submit> GetSubmits();

        [OperationContract]
        submit GetSubmit(int Id);

        [OperationContract]
        void AddSubmit(submit entity);

        [OperationContract]
        void RemoveSubmit(int Id);

        [OperationContract]
        void UpdateSubmit(submit entity);

        #endregion

        #region sysdiagram
        [OperationContract]
        List<sysdiagram> GetSysdiagrams();

        [OperationContract]
        sysdiagram GetSysdiagram(int Id);

        [OperationContract]
        void AddSysdiagram(sysdiagram entity);

        [OperationContract]
        void RemoveSysdiagram(int Id);

        [OperationContract]
        void UpdateSysdiagram(sysdiagram entity);

        #endregion

        #region tag
        [OperationContract]
        List<tag> GetTags();

        [OperationContract]
        tag GetTag(int Id);

        [OperationContract]
        void AddTag(tag entity);

        [OperationContract]
        void RemoveTag(int Id);

        [OperationContract]
        void UpdateTag(tag entity);

        #endregion

        #region tag_post
        [OperationContract]
        List<tag_post> GetTagPosts();

        [OperationContract]
        tag_post GetTagPost(int Id);

        [OperationContract]
        void AddTagPost(tag_post entity);

        [OperationContract]
        void RemoveTagPost(int Id);

        [OperationContract]
        void UpdateTagPost(tag_post entity);

        #endregion

        #region Tax_Administration
        [OperationContract]
        List<Tax_Administration> GetTax_Administrations();

        [OperationContract]
        Tax_Administration GetTax_Administration(int Id);

        [OperationContract]
        void AddTax_Administration(Tax_Administration entity);

        [OperationContract]
        void RemoveTax_Administration(int Id);

        [OperationContract]
        void UpdateTax_Administration(Tax_Administration entity);

        #endregion

        #region title
        [OperationContract]
        List<title> GetTitles();

        [OperationContract]
        title GetTitle(int Id);

        [OperationContract]
        void AddTitle(title entity);

        [OperationContract]
        void RemoveTitle(int Id);

        [OperationContract]
        void UpdateTitle(title entity);

        #endregion

        #region User
        [OperationContract]
        List<User> GetUsers();

        [OperationContract]
        User GetUser(int Id);

        [OperationContract]
        void AddUser(User entity);

        [OperationContract]
        void RemoveUser(int Id);

        [OperationContract]
        void UpdateUser(User entity);

        #endregion

        #region UserRole
        [OperationContract]
        List<UserRole> GetUserRoles();

        [OperationContract]
        UserRole GetUserRole(int Id);

        [OperationContract]
        void AddUserRole(UserRole entity);

        [OperationContract]
        void RemoveUserRole(int Id);

        [OperationContract]
        void UpdateUserRole(UserRole entity);

        #endregion

        #region UserType
        [OperationContract]
        List<UserType> GetUserTypes();

        [OperationContract]
        UserType GetUserType(int Id);

        [OperationContract]
        void AddUserType(UserType entity);

        [OperationContract]
        void RemoveUserType(int Id);

        [OperationContract]
        void UpdateUserType(UserType entity);

        #endregion

    }
}
