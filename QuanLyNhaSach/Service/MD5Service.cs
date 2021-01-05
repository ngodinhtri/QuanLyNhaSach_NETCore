
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyNhaSach.Service
{
    static class MD5Service
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString());
            }
            return hash.ToString();
        }
    }
}
