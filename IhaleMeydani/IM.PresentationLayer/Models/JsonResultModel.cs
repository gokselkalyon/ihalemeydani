using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class JsonResultModel
    {
        //Icon tipi belirlenmesi ÖRN : success,error
        public string Icon { get; set; }
        //Model Başlığı ne olucak ?
        public string Title { get; set; }
        //Model Açıklaması ne olucak ?
        public string Description { get; set; }
        //Json başarılıysa hangi url gidecek ?
        public string Url { get; set; }
        //Json başarılıysa hangi modal Id'sine sahip modal kapatılsın ?
        public string Modal { get; set; }
        //Json başarılıya hangi function çalıştırılsın ?
        public string Function { get; set; }
    }
}