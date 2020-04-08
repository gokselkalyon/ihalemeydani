using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.ServiceAdapter
{
    public class TCServiceAdapter : ITCService
    {
        public bool authentication(User user)
        {
             TCServiceReference.KPSPublicSoapClient kPSPublicSoapClient = new TCServiceReference.KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(
                Convert.ToInt64(user.IdentityNo),
                user.Name.ToUpper(),
                user.Surname.ToUpper(),
                user.Dateofbird.Value.Year);
        }
    }
}
