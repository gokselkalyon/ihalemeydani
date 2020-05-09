using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataLayer.Model
{
    public class ActionUserModel
    {
        public int ID { get; set; }
        public DateTime? DATE_OF_UPDATE { get; set; }
        public Nullable<int> auction_id { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public decimal bid { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
