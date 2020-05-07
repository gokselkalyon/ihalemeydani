using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataLayer.Model
{
    public class UserProductModel
    {
        public string username { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string hardwaredetail { get; set; }
        public string carmake { get; set; }
        public string brand { get; set; }
        public string version { get; set; }
        public string geartype { get; set; }
        public string fueltype { get; set; }
        public string segment { get; set; }
        public int EngineDisplacement { get; set; }
        public int hp { get; set; }
        public string licanceplate { get; set; }
        public int mileage { get; set; }
        public DateTime registrationdate { get; set; }
        public string vin { get; set; }
        public string colorname { get; set; }
        public string colorvalue { get; set; }

    }
}
