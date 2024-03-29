﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.helper
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });
            List<T> result = Mapper.Map<List<T>,List<T>>(list);
            return result;
        }
    }
}
