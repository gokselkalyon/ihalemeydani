﻿using IM.DataLayer;
using IM.PresentationLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.LoginSecurity
{
    public class SessionManager
    {
        static SessionManager _Current = null;

        public static SessionManager Current
        {
            get
            {
                if (_Current == null)
                    _Current = new SessionManager();
                return _Current;
            }
        }

        public static UserModel CurrentUser
        {
            get
            {
                if (SessionManager.Current.Get<UserModel>(SessionKey.CurrentUser) == null)
                {
                    return new UserModel() { Id = 0};
                }
                else
                {
                    return SessionManager.Current.Get<UserModel>(SessionKey.CurrentUser);
                }
            }
        }

        public void Set(string key, object value)
        {
            var v = JsonConvert.SerializeObject(value);
            HttpContext.Current.Session[key] = v;

        }

        public T Get<T>(string key)
            where T : class, new()
        {
            var v = (string)HttpContext.Current.Session[key];
            if (v == null)
            {
                return JsonConvert.DeserializeObject<T>(" ");
            }
            return JsonConvert.DeserializeObject<T>(v);
        } 
    }
    public static class SessionKey
    {
        public const string CurrentUser = "_CurrentUser";
    }
}