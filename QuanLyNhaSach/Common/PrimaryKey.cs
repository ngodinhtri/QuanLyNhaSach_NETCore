using QuanLyNhaSach.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Common
{
    class PrimaryKey
    {
       private static int number = 0;
        public string createKey()
        {
            Guid guid = Guid.NewGuid();
            string key = guid.ToString() + number++;
            string keyStr = MD5Service.MD5Hash(key.ToString());
            return keyStr;
        }
    }
}
