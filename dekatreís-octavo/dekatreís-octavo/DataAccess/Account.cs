using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.DataAccess
{
    public class Account
    {
        private static Account instance;

        public static Account Instance { get { if (instance == null) instance = new Account(); return instance; } set => instance = value; }

        public string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        public bool Login(string Username, string Password)
        {
            string EncryptedPass = Encrypt(Password);
            int data = (int)ExecuteQuery.Instance.ExecuteScalar(String.Format("select count(*) from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}'", Username, EncryptedPass));
            return data == 1;
        }

        public DataRow GetInfoAcc(string username)
        {
            return ExecuteQuery.Instance.ExecuteReader(String.Format("select * from TaiKhoan where TenDangNhap = '{0}'", username)).Rows[0];
        }

        public bool InsertAccount(string Username, string Password, int Type, string Name, string Sdt, string Cmnd)
        {
            string EncryptedPass = Encrypt(Password);
            //if (DisplayName == null) DisplayName = Username;
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("INSERT INTO [dbo].[TaiKhoan]([TenDangNhap],[MatKhau],[TenThat],[LoaiTaiKhoan],[SDT],[CMND])VALUES ('{0}','{1}','{2}',{3},'{4}','{5}')", 
                                                                                                        Username, EncryptedPass, Name, Type, Sdt, Cmnd)) > 0;
        }
        
        public void CheckAccount()
        {
            if (0 == (int)ExecuteQuery.Instance.ExecuteScalar(string.Format("select count(*) from TaiKhoan")))
            {
                InsertAccount("admin", "admin", 1, "admin", "", "");
                InsertAccount("staff", "staff", 2, "staff", "", "");
            }
            return;
        }
    }
}
