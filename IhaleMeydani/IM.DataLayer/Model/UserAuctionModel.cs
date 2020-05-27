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
        public int userid { get; set; }
        public int CarDetailId { get; set; }
        public string CarBrandName { get; set; }
        public int CURRENCY_ID { get; set; }
        public string LicancePlate { get; set; }
        public bool published_on { get; set; }
        public bool isSaled { get; set; }


    }
}
