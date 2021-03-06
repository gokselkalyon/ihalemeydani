﻿using IM.DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
	public class UserModelView
	{
		public List<UserModel> userModelList { get; set; }
		public List<RoleModel> roleModelList { get; set; }

		public UserModel userModel { get; set; }
	}
	public class UserModel
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
		public List<string> claimText { get; set; }
		public string Password { get; set; }
		public string Password2 { get; set; }
		public string Password3 { get; set; }
	}
}