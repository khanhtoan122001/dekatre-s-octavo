using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class BaoCaoChamCongNhanVienBus
    {
        private static BaoCaoChamCongNhanVienBus instance;

        public static BaoCaoChamCongNhanVienBus Instance { get { if (instance == null) instance = new BaoCaoChamCongNhanVienBus(); return instance; } set => instance = value; }

        public void ChamCong()
        {
            if (DataProvider.Instance.TaiKhoan == null)
                return;
            else
            {
                TaiKhoan tk = DataProvider.Instance.TaiKhoan;
                QuanLyDoXeEntities1 db = DataProvider.Instance.db;
                DateTime date = DateTime.Now.Date;
                var result = (from c in db.BaoCaoChamCongNhanViens
                              where c.ThoiGian == date && c.TenDangNhap == tk.TenDangNhap
                              select c).ToList().Count() == 1;
                if (!result)
                {
                    db.BaoCaoChamCongNhanViens.Add(new BaoCaoChamCongNhanVien() { TaiKhoan = DataProvider.Instance.TaiKhoan, ThoiGian = DateTime.Now.Date });
                    db.SaveChanges();
                }
                else return;
            }
        }

        public List<BaoCaoChamCongNhanVien> GetBaoCaoChamCongNhanViens(string TenDangNhap, int? thang = null, int? nam = null)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.BaoCaoChamCongNhanViens
                         where c.TenDangNhap == TenDangNhap
                         select c;

            if(thang != null && nam != null)
            {
                result = result.Where(p => p.ThoiGian.Year == nam && p.ThoiGian.Month == thang);
            }

            return result.ToList();
        }

    }
}
