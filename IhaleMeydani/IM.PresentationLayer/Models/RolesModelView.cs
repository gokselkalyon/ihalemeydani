﻿using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace IM.PresentationLayer.Models
{
    public class RolesModelView
    {
        public List<RoleModel> roleList { get; set; }
        public List<ClaimGroupModelView> claimGroupList { get; set; }
        public string RoleName { get; set; }
        public int Id { get; set; }  

    }
    public class RoleModel
    {
        public int RoleId { get; set; }
        public bool Checked { get; set; }
        public string Text { get; set; } 
        public int ClaimId { get; set; }
        public int? ClaimGroupId { get; set; }

    }
}