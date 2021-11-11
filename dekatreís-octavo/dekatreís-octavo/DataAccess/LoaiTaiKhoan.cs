using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.DataAccess
{
    public class LoaiTaiKhoan
    {
        private static LoaiTaiKhoan instance;

        public static LoaiTaiKhoan Instance { get { if (instance == null) instance = new LoaiTaiKhoan(); return instance; } set => instance = value; }
        public bool InsertLoaiTaiKhoan(string TenLoai)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(string.Format("INSERT INTO [dbo].[LoaiTaiKhoan]([TenLoai])VALUES('{0}')", TenLoai)) > 0;
        }

        public void CheckLoaiTaiKhoan()
        {
            if ((int)ExecuteQuery.Instance.ExecuteScalar("select count(*) from LoaiTaiKhoan") == 0)
            {
                InsertLoaiTaiKhoan("admin");
                InsertLoaiTaiKhoan("staff");
            }
            return;
        }
    }
}
