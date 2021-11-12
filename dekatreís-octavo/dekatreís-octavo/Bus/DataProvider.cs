using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class DataProvider
    {
        private static DataProvider instance;
        public QuanLyDoXeEntities db;
        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return instance; } set => instance = value; }

        public TaiKhoan TaiKhoan;
        public string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
    }
}
