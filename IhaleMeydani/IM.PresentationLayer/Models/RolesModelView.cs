using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace IM.PresentationLayer.Models
{
    public class RolesModelView
    {
        public bool Checked { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}