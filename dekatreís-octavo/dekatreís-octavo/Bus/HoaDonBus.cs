using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class HoaDonBus
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        private static HoaDonBus instance;

        public static HoaDonBus Instance { get { if (instance == null) instance = new HoaDonBus(); return instance; } set => instance = value; }

        public bool AddHoaDon(string BienSo, int GiaTien)
        {
            HoaDon hoaDon = new HoaDon() { BienSo = BienSo, ThanhTien = GiaTien, ThoiGian = DateTime.Now };

            var result = db.HoaDons.Add(hoaDon);

            db.SaveChanges();

            return result != null;
        }


    }
}
