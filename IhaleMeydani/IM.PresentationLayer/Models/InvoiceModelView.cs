using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class InvoiceModelView
    {
		public UserProductModel userProduct { get; set; }
		public User saledUser { get; set; }
		public User saleUser { get; set; }
		public E_INVOICE eInvoice { get; set; }
		public int KDV { get; set; }
		public double KfvliFiyat { get; set; } 

	}
    public class InvoiceModel
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Adress { get; set; }
		public string CompanyName { get; set; }
		public string Email { get; set; }
		public DateTime? DateOfBirt { get; set; }
		public string IdentityNo { get; set; }
		public string Phone { get; set; }
		public bool? IsDeleted { get; set; }
		public string CityName { get; set; }
		public string Username { get; set; }
		public string BrandName { get; set; }

	}
}