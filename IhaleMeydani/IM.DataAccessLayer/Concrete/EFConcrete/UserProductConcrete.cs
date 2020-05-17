using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using IM.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class UserProductConcrete : BaseConcrete, IDataAccessDal<userproduct>, IDataBaseQuery<UserProductModel>
    {
        public void Add(userproduct entity)
        {
            DB.userproducts.Add(entity);
            DB.SaveChanges();
        }
        public void Add(UserProductModel entity, string id)
        {
            // DB.userproducts.Add(entity);
            // DB.SaveChanges();
        }

        public userproduct Get(int id)
        {
            return DB.userproducts.Find(id);
        }

        public List<userproduct> GetAll()
        {
            return DB.userproducts.ToList();
        }

        public IEnumerable<userproduct> GetFilter(Expression<Func<userproduct, bool>> expression)
        {
            return DB.userproducts.Where(expression);
        }

        public int MultiAdded(UserProductModel t)
        {
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                    Color color = new Color { ColorName = t.ColorName, ColorValue = t.ColorValue };
                    CarBrand brand = new CarBrand { CarBrandName = t.CarBrandName };
                    Segment segment = new Segment { SegmentName = t.SegmentName };
                    FuelType fuelType = new FuelType { FuelTypeName = t.FuelTypeName };
                    GearType gearType = new GearType { GearTypeName = t.GearTypeName };

                    DB.Colors.Add(color);
                    DB.CarBrands.Add(brand);
                    DB.Segments.Add(segment);
                    DB.FuelTypes.Add(fuelType);
                    DB.GearTypes.Add(gearType);
                    DB.SaveChanges();

                    CarMake carMake = new CarMake { CarMakeName = t.CarMakeName, CarBrandId = brand.CarBrandId };
                    CarHardwareDetail carHardwareDetail = new CarHardwareDetail { HardwareDetail = t.HardwareDetail, CarDetailId = 1 };
                    DB.CarHardwareDetails.Add(carHardwareDetail);
                    DB.CarMakes.Add(carMake);
                    DB.SaveChanges();


                    CarTechnicalDetail carTechnicalDetai = new CarTechnicalDetail
                    {
                        registrationDate = DateTime.Now,
                        CarMakeId = carMake.CarMakeId,
                        CarVersion = t.CarVersion,
                        ColorId = color.ColorId,
                        EngineDisplacement = t.EngineDisplacement,
                        FuelType_Id = fuelType.FuelTypeId,
                        GearTypeId = gearType.GearTypeId,
                        HP = t.HP,
                        LicancePlate = t.LicancePlate,
                        Mileage = t.Mileage,
                        SegmentId = segment.SegmentId,
                        VIN = t.VIN
                        
                    };

                    DB.CarTechnicalDetails.Add(carTechnicalDetai);

                    DB.SaveChanges();


                    CarDetail carDetail = new CarDetail
                    {
                        CarTechnicalId = carTechnicalDetai.CarTechnicalDetailId,
                        CarHardwareId = carHardwareDetail.CarDetailId
                    };
                    DB.CarDetails.Add(carDetail);
                    DB.SaveChanges();

                    userproduct userproduct = new userproduct
                    {
                        cardetail_id = carDetail.CarDetailId,
                        user_id = t.user_id,
                        published_on = true,
                        date_of_created = DateTime.Now,
                        date_of_updated = DateTime.Now,
                        isdeleted =false,
                        isSaled = false
                    };
                    DB.userproducts.Add(userproduct);
                    DB.SaveChanges();
                    
                    transaction.Commit();
                    return userproduct.id;
                }
                catch (Exception ex)
                {
                    var deneme = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        public int Multiupdate(UserProductModel t)
        {
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                    Color color = new Color { ColorName = t.ColorName, ColorValue = t.ColorValue ,ColorId =t.ColorId};
                    CarBrand brand = new CarBrand { CarBrandName = t.CarBrandName ,CarBrandId = t.CarBrandId};
                    Segment segment = new Segment { SegmentName = t.SegmentName ,SegmentId = t.SegmentId};
                    FuelType fuelType = new FuelType { FuelTypeName = t.FuelTypeName, FuelTypeId = t.FuelTypeId };
                    GearType gearType = new GearType { GearTypeName = t.GearTypeName ,GearTypeId = t.GearTypeId };

                    DB.Colors.Attach(color);
                    DB.Entry(color).State = System.Data.Entity.EntityState.Modified;
                    DB.CarBrands.Attach(brand);
                    DB.Entry(brand).State = System.Data.Entity.EntityState.Modified;
                    DB.Segments.Attach(segment);
                    DB.Entry(segment).State = System.Data.Entity.EntityState.Modified;
                    DB.FuelTypes.Attach(fuelType);
                    DB.Entry(fuelType).State = System.Data.Entity.EntityState.Modified;
                    DB.GearTypes.Attach(gearType);
                    DB.Entry(gearType).State = System.Data.Entity.EntityState.Modified;
                    CarMake carMake = new CarMake { CarMakeName = t.CarMakeName,CarMakeId = t.CarMakeId ,CarBrandId = t.CarBrandId};
                    CarHardwareDetail carHardwareDetail = new CarHardwareDetail { HardwareDetail = t.HardwareDetail, CarDetailId = 1,CarHardwareDetailsId = t.CarHardwareDetailsId };
                    DB.CarHardwareDetails.Attach(carHardwareDetail);
                    DB.Entry(carHardwareDetail).State = System.Data.Entity.EntityState.Modified;
                    DB.CarMakes.Attach(carMake);
                    DB.Entry(carMake).State = System.Data.Entity.EntityState.Modified;
                    CarTechnicalDetail carTechnicalDetai = new CarTechnicalDetail
                    {
                        registrationDate = DateTime.Now,
                        CarVersion = t.CarVersion,
                        EngineDisplacement = t.EngineDisplacement,
                        HP = t.HP,
                        LicancePlate = t.LicancePlate,
                        Mileage = t.Mileage,
                        VIN = t.VIN,
                        CarTechnicalDetailId = t.CarTechnicalDetailId,
                        CarMakeId = t.CarMakeId,
                        ColorId = t.ColorId,
                        FuelType_Id = t.FuelTypeId,
                        GearTypeId = t.GearTypeId,
                        SegmentId = t.SegmentId,
                    };
                    DB.CarTechnicalDetails.Add(carTechnicalDetai);
                    DB.Entry(carTechnicalDetai).State = System.Data.Entity.EntityState.Modified;
                    CarDetail carDetail = new CarDetail
                    {
                        CarHardwareId = t.CarHardwareDetailsId,
                        CarTechnicalId = t.CarTechnicalDetailId,
                        CarDetailId = t.CarDetailId
                    };
                    DB.CarDetails.Attach(carDetail);
                    DB.Entry(carDetail).State = System.Data.Entity.EntityState.Modified;
                    userproduct userproduct = new userproduct
                    {
                        user_id = t.user_id,
                        published_on = t.published_on,
                        date_of_created = DateTime.Now,
                        date_of_updated = DateTime.Now,
                        isdeleted = false,
                        id = t.id,
                        cardetail_id = t.CarDetailId,
                        isSaled = t.isSaled
                    };
                    DB.userproducts.Attach(userproduct);
                    DB.Entry(userproduct).State = System.Data.Entity.EntityState.Modified;

                    DB.SaveChanges();

                    transaction.Commit();
                    return userproduct.id;
                }
                catch (Exception ex)
                {
                    var deneme = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
        }


        public List<UserProductModel> QueryList()
        {
            return DB.Database.SqlQuery<UserProductModel>("select * from userproductviews").ToList();
        }

        public void Remove(int id)
        {
            DB.userproducts.Remove(DB.userproducts.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(userproduct t)
        {
            DB.userproducts.Remove(t);
            DB.SaveChanges();
        }

        public void Update(userproduct t)
        {
            DB.userproducts.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
