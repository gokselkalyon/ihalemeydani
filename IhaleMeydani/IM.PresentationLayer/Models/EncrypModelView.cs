﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class EncrypModelView
    {
        public static string GetMD5Hash(string input)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] b = System.Text.Encoding.UTF8.GetBytes(input);
                b = md5.ComputeHash(b);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte x in b)
                    sb.Append(x.ToString("x2"));
                return sb.ToString();
            }
        }
        public static string EncryptSHA1(string text)
        {
            StringBuilder sb = new StringBuilder();
            if (text != null)
            {
                SHA1 sha1 = SHA1.Create();
                byte[] array = sha1.ComputeHash(Encoding.Default.GetBytes(text));

                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append(array[i].ToString("x2"));
                }
                return sb.ToString();
            }
            return sb.ToString();
        }
    }
}