﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IM.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IHALEDBEntities : DbContext
    {
        public IHALEDBEntities()
            : base("name=IHALEDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMOUNT_OF_INCREASE> AMOUNT_OF_INCREASE { get; set; }
        public virtual DbSet<auction> auctions { get; set; }
        public virtual DbSet<bank> banks { get; set; }
        public virtual DbSet<CarBrand> CarBrands { get; set; }
        public virtual DbSet<CarDetail> CarDetails { get; set; }
        public virtual DbSet<CarHardwareDetail> CarHardwareDetails { get; set; }
        public virtual DbSet<CarMake> CarMakes { get; set; }
        public virtual DbSet<CarTechnicalDetail> CarTechnicalDetails { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<company_type> company_type { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<county> counties { get; set; }
        public virtual DbSet<CURRENCY> CURRENCies { get; set; }
        public virtual DbSet<discountcart> discountcarts { get; set; }
        public virtual DbSet<E_INVOICE> E_INVOICE { get; set; }
        public virtual DbSet<E_invoice_type> E_invoice_type { get; set; }
        public virtual DbSet<employee_position> employee_position { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<FuelType> FuelTypes { get; set; }
        public virtual DbSet<GearType> GearTypes { get; set; }
        public virtual DbSet<GeneralDesign> GeneralDesigns { get; set; }
        public virtual DbSet<Icon> Icons { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<medium> media { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<natification> natifications { get; set; }
        public virtual DbSet<odeme_yontemi> odeme_yontemi { get; set; }
        public virtual DbSet<payment_plan> payment_plan { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PRICEBOT> PRICEBOTs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleClaim> RoleClaims { get; set; }
        public virtual DbSet<Segment> Segments { get; set; }
        public virtual DbSet<senaryo> senaryoes { get; set; }
        public virtual DbSet<SocialMedya> SocialMedyas { get; set; }
        public virtual DbSet<SOLD_PRODUCT> SOLD_PRODUCT { get; set; }
        public virtual DbSet<submit> submits { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tag> tags { get; set; }
        public virtual DbSet<tag_post> tag_post { get; set; }
        public virtual DbSet<Tax_Administration> Tax_Administration { get; set; }
        public virtual DbSet<title> titles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    }
}
