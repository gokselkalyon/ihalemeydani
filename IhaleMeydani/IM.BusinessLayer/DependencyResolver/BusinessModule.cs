using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.Concrete;
using IM.BusinessLayer.ServiceAdapter;
using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.EFConcrete;
using IM.DataLayer;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataBusinessService<AMOUNT_OF_INCREASE>>().To<AmountOfIncreaseManager>().InSingletonScope();
            Bind<IDataBusinessService<auction>>().To<AuctionManager>().InSingletonScope();
            Bind<IDataBusinessService<bank>>().To<BankManager>().InSingletonScope();
            Bind<IDataBusinessService<CarBrand>>().To<CarBrandManager>().InSingletonScope();
            Bind<IDataBusinessService<CarDetail>>().To<CarDetailManager>().InSingletonScope();
            Bind<IDataBusinessService<CarHardwareDetail>>().To<CarHardwareDetailsManager>().InSingletonScope();
            Bind<IDataBusinessService<CarMake>>().To<CarMakeManagerr>().InSingletonScope();
            Bind<IDataBusinessService<CarTechnicalDetail>>().To<CarTechnicalDetailManager>().InSingletonScope();
            Bind<IDataBusinessService<city>>().To<CityManager>().InSingletonScope();
            Bind<IDataBusinessService<Claim>>().To<ClaimManager>().InSingletonScope();
            Bind<IDataBusinessService<Color>>().To<ColorManager>().InSingletonScope();
            Bind<IDataBusinessService<company_type>>().To<CompanyTypeManager>().InSingletonScope();
            Bind<IDataBusinessService<company>>().To<CompanyManager>().InSingletonScope();
            Bind<IDataBusinessService<country>>().To<CountryManager>().InSingletonScope();
            Bind<IDataBusinessService<county>>().To<CountyManager>().InSingletonScope();
            Bind<IDataBusinessService<CURRENCY>>().To<CurrencyManager>().InSingletonScope();
            Bind<IDataBusinessService<discountcart>>().To<DiscountCartManager>().InSingletonScope();
            Bind<IDataBusinessService<E_invoice_type>>().To<EInvoiceTypeManager>().InSingletonScope();
            Bind<IDataBusinessService<E_INVOICE>>().To<E_InvoiceManager>().InSingletonScope();
            Bind<IDataBusinessService<employee_position>>().To<EmployeePositionManager>().InSingletonScope();
            Bind<IDataBusinessService<employee>>().To<EmployeeManager>().InSingletonScope();
            Bind<IDataBusinessService<FuelType>>().To<FuelTypeManager>().InSingletonScope();
            Bind<IDataBusinessService<GearType>>().To<GearTyPeManager>().InSingletonScope();
            Bind<IDataBusinessService<GeneralDesign>>().To<GeneralDesignManager>().InSingletonScope();
            Bind<IDataBusinessService<Icon>>().To<IconManager>().InSingletonScope();
            Bind<IDataBusinessService<Image>>().To<ImageManager>().InSingletonScope();
            Bind<IDataBusinessService<log>>().To<LogManager>().InSingletonScope();
            Bind<IDataBusinessService<medium>>().To<MediumManager>().InSingletonScope();
            Bind<IDataBusinessService<Menu>>().To<MenuManager>().InSingletonScope();
            Bind<IDataBusinessService<natification>>().To<NatificationManager>().InSingletonScope();
            Bind<IDataBusinessService<odeme_yontemi>>().To<OdemeYontemiManager>().InSingletonScope();
            Bind<IDataBusinessService<payment_plan>>().To<PaymentPlanManager>().InSingletonScope();
            Bind<IDataBusinessService<Post>>().To<PostManager>().InSingletonScope();
            Bind<IDataBusinessService<PRICEBOT>>().To<PriceBotManager>().InSingletonScope();
            Bind<IDataBusinessService<RoleClaim>>().To<RoleClaimManager>().InSingletonScope();
            Bind<IDataBusinessService<Role>>().To<RoleManager>().InSingletonScope();
            Bind<IDataBusinessService<Segment>>().To<SegmentManager>().InSingletonScope();
            Bind<IDataBusinessService<senaryo>>().To<SeneryoManager>().InSingletonScope();
            Bind<IDataBusinessService<SocialMedya>>().To<SocialMediaManager>().InSingletonScope();
            Bind<IDataBusinessService<SOLD_PRODUCT>>().To<SoldProductManager>().InSingletonScope();
            Bind<IDataBusinessService<submit>>().To<SubmitManager>().InSingletonScope();
            Bind<IDataBusinessService<tag>>().To<TagManager>().InSingletonScope();
            Bind<IDataBusinessService<tag_post>>().To<TagPostManager>().InSingletonScope();
            Bind<IDataBusinessService<Tax_Administration>>().To<TaxAdminstrationManager>().InSingletonScope();
            Bind<IDataBusinessService<title>>().To<TitleManager>().InSingletonScope();
            Bind<IDataBusinessService<User>>().To<UserManager>().InSingletonScope();
            Bind<IDataBusinessService<UserRole>>().To<UserRoleManager>().InSingletonScope();
            Bind<IDataBusinessService<UserType>>().To<UserTypeManager>().InSingletonScope();
            Bind<IDataBusinessService<private_auction>>().To<PrivateAuctionManager>().InSingletonScope();
            Bind<IDataBusinessService<actionuser>>().To<AuctionUserManager>().InSingletonScope();
            Bind<IDataBusinessService<userproduct>>().To<UserProductManager>().InSingletonScope();


            Bind<IDataAccessDal<log>>().To<LogConcrete>().InSingletonScope();
            Bind<IDataAccessDal<AMOUNT_OF_INCREASE>>().To<Amount_Of_IncreaseConcrete>().InSingletonScope();
            Bind<IDataAccessDal<auction>>().To<AuctionConcrete>().InSingletonScope();
            Bind<IDataAccessDal<private_auction>>().To<PrivateAuctionConcrete>().InSingletonScope();
            Bind<IDataAccessDal<actionuser>>().To<AuctionUserConcrete>().InSingletonScope();
            Bind<IDataAccessDal<bank>>().To<BankConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CarBrand>>().To<CarBrandConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CarDetail>>().To<CarDetailConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CarHardwareDetail>>().To<CarHardwareDetailConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CarMake>>().To<CarMakeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CarTechnicalDetail>>().To<CarTechnicalDetailConcrete>().InSingletonScope();
            Bind<IDataAccessDal<city>>().To<CityConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Claim>>().To<ClaimConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Color>>().To<ColorConcrete>().InSingletonScope();
            Bind<IDataAccessDal<company>>().To<CompanyConcrete>().InSingletonScope();
            Bind<IDataAccessDal<company_type>>().To<Company_TypeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<county>>().To<CountyConcrete>().InSingletonScope();
            Bind<IDataAccessDal<country>>().To<CountryConcrete>().InSingletonScope();
            Bind<IDataAccessDal<CURRENCY>>().To<CurrencyConcrete>().InSingletonScope();
            Bind<IDataAccessDal<discountcart>>().To<DiscountcartConcrete>().InSingletonScope();
            Bind<IDataAccessDal<E_invoice_type>>().To<E_Invoice_TypeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<E_INVOICE>>().To<E_invoiceConcrete>().InSingletonScope();
            Bind<IDataAccessDal<employee_position>>().To<Employee_PositionConcrete>().InSingletonScope();
            Bind<IDataAccessDal<employee>>().To<EmployeeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<FuelType>>().To<FuelTypeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<GearType>>().To<GearTypeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<GeneralDesign>>().To<GeneralDesignConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Icon>>().To<IconConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Image>>().To<ImageConcrete>().InSingletonScope();
            Bind<IDataAccessDal<medium>>().To<MediumConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Menu>>().To<MenuConcrete>().InSingletonScope();
            Bind<IDataAccessDal<natification>>().To<NatificationConcrete>().InSingletonScope();
            Bind<IDataAccessDal<odeme_yontemi>>().To<Odeme_YontemiConcrete>().InSingletonScope();
            Bind<IDataAccessDal<payment_plan>>().To<Payment_PlanConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Post>>().To<PostConcrete>().InSingletonScope();
            Bind<IDataAccessDal<PRICEBOT>>().To<PricebotConcrete>().InSingletonScope();
            Bind<IDataAccessDal<RoleClaim>>().To<RoleClaimConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Role>>().To<RoleConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Segment>>().To<SegmentConcrete>().InSingletonScope();
            Bind<IDataAccessDal<senaryo>>().To<SenaryoConcrete>().InSingletonScope();
            Bind<IDataAccessDal<SocialMedya>>().To<SocialMedyaConcrete>().InSingletonScope();
            Bind<IDataAccessDal<SOLD_PRODUCT>>().To<Sold_ProductConcrete>().InSingletonScope();
            Bind<IDataAccessDal<submit>>().To<SubmitConcrete>().InSingletonScope();
            Bind<IDataAccessDal<tag_post>>().To<Tag_PostConcrete>().InSingletonScope();
            Bind<IDataAccessDal<tag>>().To<TagConcrete>().InSingletonScope();
            Bind<IDataAccessDal<Tax_Administration>>().To<Tax_AdministrationConcrete>().InSingletonScope();
            Bind<IDataAccessDal<title>>().To<TitleConcrete>().InSingletonScope();
            Bind<IDataAccessDal<UserRole>>().To<UserRoleConcrete>().InSingletonScope();
            Bind<IDataAccessDal<UserType>>().To<UserTypeConcrete>().InSingletonScope();
            Bind<IDataAccessDal<User>>().To<UserConcrete>().InSingletonScope();
            Bind<IDataAccessDal<userproduct>>().To<UserProductConcrete>().InSingletonScope();

            Bind<ITCService>().To<TCServiceAdapter>().InSingletonScope();
        }
    }
}
