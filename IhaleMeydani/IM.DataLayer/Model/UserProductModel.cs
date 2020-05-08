using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataLayer.Model
{
    public class UserProductModel
    {
        public int id { get; set; }
        public Nullable<int> user_id { get; set; }
        public bool published_on { get; set; }
        public bool isdeleted { get; set; }
        public DateTime? date_of_created { get; set; }
        public DateTime? date_of_updated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string HardwareDetail { get; set; }
        public string CarMakeName { get; set; }
        public string CarBrandName { get; set; }
        public string CarVersion { get; set; }
        public string GearTypeName { get; set; }
        public string FuelTypeName { get; set; }
        public string SegmentName { get; set; }
        public int EngineDisplacement { get; set; }
        public int HP { get; set; }
        public string LicancePlate { get; set; }
        public int Mileage { get; set; }
        public DateTime? registrationDate { get; set; }
        public string VIN { get; set; }
        public string ColorName { get; set; }
        public string ColorValue { get; set; }

    }
}
