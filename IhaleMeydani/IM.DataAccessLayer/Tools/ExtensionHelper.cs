using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Tools
{
    public static class ExtensionHelper
    {
        //String Null Yada Boş Kontrolü
        public static bool IsNull(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            else
                return true;
        }

        //Sayısal Değer Kontrolü
        public static bool IsNumeric(this string value)
        {
            foreach (char chr in value)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        /// <summary>
        /// Convert string to int value
        /// </summary>
        /// <param name="value">String Value</param>
        /// <returns></returns>
        public static int IntConvert(this string value)
        {
            return int.Parse(value);
        }
        public static int ObjectIntConvert(this object value)
        {
            return Convert.ToInt32(value);
        }
    }
}
