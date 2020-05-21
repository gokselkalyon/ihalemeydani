using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class ClaimModelView
    {
        public List<ClaimModel> claimGroupList { get; set; }
        public ClaimModel claimModel { get; set; }
    }
    public class ClaimModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ClaimGroupName { get; set; }
    }
}