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

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

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

        public void ChamCong_Login()
        {
            //if (DataProvider.Instance.TaiKhoan == null)
            //    return;
            //TaiKhoan taikhoan = DataProvider.Instance.TaiKhoan;
            //BaoCaoChamCongNhanVien baocao = new BaoCaoChamCongNhanVien()
            //{
            //    TaiKhoan = taikhoan,
            //    TenDangNhap = taikhoan.TenDangNhap,
            //    ThoiGian = DateTime.Now,
            //    IsLogin = true
            //};
            //db.BaoCaoChamCongNhanViens.Add(baocao);
            //db.SaveChanges();
        }
        public void ChamCong_Logout(int ThoiGian)
        {
            if (DataProvider.Instance.TaiKhoan == null)
                return;
            TaiKhoan taikhoan = DataProvider.Instance.TaiKhoan;
            DateTime date = DateTime.Now.Date;
            var i = db.BaoCaoChamCongNhanViens
                .Where(p => p.TenDangNhap == taikhoan.TenDangNhap && p.ThoiGian == date).ToList();
            if (i.Count != 0)
            {
                i.First().ThoiGianLamViec += ThoiGian;
            }
            else
            {
                BaoCaoChamCongNhanVien baocao = new BaoCaoChamCongNhanVien()
                {
                    TaiKhoan = taikhoan,
                    TenDangNhap = taikhoan.TenDangNhap,
                    ThoiGian = DateTime.Now.Date,
                    IsLogin = false,
                    ThoiGianLamViec = ThoiGian
                };
                db.BaoCaoChamCongNhanViens.Add(baocao);
            }
            db.SaveChanges();
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
