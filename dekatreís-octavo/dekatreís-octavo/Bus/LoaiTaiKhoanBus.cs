using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class LoaiTaiKhoanBus
    {
        private static LoaiTaiKhoanBus instance;

        public static LoaiTaiKhoanBus Instance { get { if (instance == null) instance = new LoaiTaiKhoanBus(); return instance; } set => instance = value; }

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        public int GetIdByTen(string ten)
        {
            var result = db.LoaiTaiKhoans.Where(p => p.TenLoai == ten).SingleOrDefault();
            if (result != null)
                return result.IDLoai;
            return -1;
        }

    }
}
