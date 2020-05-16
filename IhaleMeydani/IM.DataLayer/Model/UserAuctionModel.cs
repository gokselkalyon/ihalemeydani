using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataLayer.Model
{
    public class UserAuctionModel
    {
        public DateTime? ACUTION_DATE { get; set; }
        public int ACUTION_SALES_TIME { get; set; }
        public int ID { get; set; }
        public int AoFID { get; set; }
        public DateTime? DATE_OF_UPDATE { get; set; }
        public decimal INCREASE_PRICE { get; set; }
        public decimal MAX_PRICE { get; set; }
        public decimal MIN_PRICE { get; set; }
        public string NAME { get; set; } //currency name
        public int userproductID { get; set; }
        public bool isdeleted { get; set; }
        public DateTime? date_of_created { get; set; }
        public string UserName { get; set; }
        public string HardwareDetail { get; set; }
        public string CarMakeName { get; set; }
        public string CarBrandName { get; set; }
        public string CarVersion { get; set; }
        public string ColorName { get; set; }
        public string ColorValue { get; set; }
        public string GearTypeName { get; set; }
        public string FuelTypeName { get; set; }
        public string SegmentName { get; set; }
        public int EngineDisplacement { get; set; }
        public int HP { get; set; }
        public string LicancePlate { get; set; }
        public int Mileage { get; set; }
        public DateTime? registrationDate { get; set; }
        public string VIN { get; set; }
    }
}
