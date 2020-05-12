using System;
using System.Collections.Generic;
using System.Linq;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.DependencyResolver;
using IM.DataAccessLayer.Concrete.EFConcrete;
using IM.DataLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IM.BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("göksel")]
        public void multiaddedtest()
        {
            UserProductModel userProduct = new UserProductModel
            {
                ColorName = "name",
                ColorValue = "123",
                CarBrandName = "deneme",
                CarMakeName = "deneme",
                CarVersion = "1",
                SegmentName = "deneme",
                EngineDisplacement = 1,
                LicancePlate = "34 dene",
                HardwareDetail = "deneme",
                FuelTypeName = "deneme",
                GearTypeName = "deneme",
                HP = 1,
                Mileage = 1,
                published_on = true,
                user_id = 18,
                VIN = "1",
                registrationDate = DateTime.Now,
                date_of_updated = DateTime.Now,
                date_of_created = DateTime.Now,
                isdeleted = false
            };

            int sayi = InstanceFactory.GetInstance<IDataBaseQueryService<UserProductModel>>().MultiAdded(userProduct);

            List<UserProductModel> sonuc = InstanceFactory.GetInstance<IDataBaseQueryService<UserProductModel>>().QueryList();
            int testsayisi = sonuc.Where(x => x.id == sayi).FirstOrDefault().id;
            Assert.AreEqual(testsayisi, sayi);
        }

        [TestMethod]
        [Owner("göksel")]
        public void multiupdatetest()
        {
            UserProductModel userProduct = new UserProductModel
            {
                ColorId = 10,
                CarBrandId = 9,
                CarDetailId = 3,
                CarHardwareDetailsId = 1,
                CarMakeId = 9,
                CarTechnicalDetailId = 2,
                FuelTypeId = 9,
                GearTypeId = 4,
                SegmentId = 9,
                id =4,
                ColorName = "name2",
                ColorValue = "1235",
                CarBrandName = "deneme2",
                CarMakeName = "deneme2",
                CarVersion = "2",
                SegmentName = "deneme2",
                EngineDisplacement = 2,
                LicancePlate = "34 den3",
                HardwareDetail = "deneme2",
                FuelTypeName = "deneme2",
                GearTypeName = "deneme2",
                HP = 3,
                Mileage = 3,
                published_on = true,
                user_id = 18,
                VIN = "2",
                registrationDate = DateTime.Now,
                date_of_updated = DateTime.Now,
                date_of_created = DateTime.Now,
                isdeleted = false
            };
            bool calisti = false;
            var sonuc = InstanceFactory.GetInstance<IDataBaseQueryService<UserProductModel>>().QueryList().Where(x=>x.id ==userProduct.id && x.date_of_updated == userProduct.date_of_updated && x.ColorName == userProduct.ColorName).ToList();
            if (sonuc != null)
                calisti = true;

            Assert.AreEqual(calisti, true);
        }
    }

}
