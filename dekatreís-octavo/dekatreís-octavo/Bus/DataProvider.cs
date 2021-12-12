using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dekatreís_octavo.Bus
{
    public class DataProvider
    {
        const string LogPath = @".//Log.txt";

        private static DataProvider instance;
        public QuanLyDoXeEntities1 db;
        private bool isUpdate = false;
        private DateTime dateUpdate;
        private int thoiGianLamViec = 0;
        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return instance; } set => instance = value; }

        public bool IsUpdate { get => isUpdate; set => isUpdate = value; }
        public DateTime DateUpdate { get => dateUpdate; set => dateUpdate = value; }
        public int ThoiGianLamViec { get => thoiGianLamViec; set => thoiGianLamViec = value; }
        public int SoXeTrongBai { get => db.TheXes.Count(p => p.Status == true); }

        public TaiKhoan TaiKhoan;
        DataProvider()
        {
            if (db == null)
            {
                db = new QuanLyDoXeEntities1();
            }
        }

        public void ReadLog()
        {
            ReadLogUpdate();
            if (dateUpdate < DateTime.Now || (dateUpdate == DateTime.Now && isUpdate == false))
            {
                Update();
            }
        }

        public void Update()
        {
            ThamSoBus.Instance.Update();
            LoaiTheBus.Instance.Update();
            if(isUpdate == false)
            {
                isUpdate = true;
                WriteLogUpdate();
            }
        }

        public void CreateDataDefault()
        {
            LoginViewBus.Instance.CheckDataAccount();
            ThamSoBus.Instance.SetDefaultThamSo();
            LoaiTheBus.Instance.CheckLoaiThe();
            CardManagementBus.Instance.SetDefault();
        }

        public string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }

        public void WriteLogUpdate()
        {
            if (!File.Exists(LogPath))
            {
                using (StreamWriter sw = new StreamWriter(LogPath))
                {
                    sw.WriteLine(string.Format("Update*{0}*{1}*", DateTime.Now.Date.ToString(), IsUpdate));
                }
            }
        }
        public void ReadLogUpdate()
        {
            if (File.Exists(LogPath))
            {
                using (StreamReader sd = new StreamReader(LogPath))
                {
                    string i = sd.ReadLine();
                    string strUpdate, strDate, strTrueFalse;
                    strUpdate = i.Substring(0, i.IndexOf('*'));
                    i = i.Substring(i.IndexOf('*') + 1);
                    strDate = i.Substring(0, i.IndexOf('*'));
                    i = i.Substring(i.IndexOf('*') + 1);
                    strTrueFalse = i.Substring(0, i.IndexOf('*'));
                    dateUpdate = DateTime.Parse(strDate);
                    isUpdate = bool.Parse(strTrueFalse);
                }
            }
        }
    }
}
