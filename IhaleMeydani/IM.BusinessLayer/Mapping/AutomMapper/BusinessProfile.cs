using AutoMapper;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Mapping.AutomMapper
{
    public class BusinessProfile:Profile
    {
        public BusinessProfile()
        {
            CreateMap<log, log>();
        }
    }
}
