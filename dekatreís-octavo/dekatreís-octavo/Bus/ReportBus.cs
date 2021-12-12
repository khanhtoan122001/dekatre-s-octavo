using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class ReportBus
    {
        private static ReportBus instance;

        public static ReportBus Instance { get { if (instance == null) instance = new ReportBus(); return instance; } set => instance = value; }

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        public bool AddBaoCaoLichSuHoatDong(DateTime date, int HoatDong)
        {
            var list = db.BaoCaoLichSuHoatDongs.Where(p => p.Ngay == date && p.HoatDong == HoatDong).ToList();
            if (list.Count != 0)
                return true;
            BaoCaoLichSuHoatDong report = new BaoCaoLichSuHoatDong();
            report.HoatDong = HoatDong;
            report.Ngay = date;
            var result = db.BaoCaoLichSuHoatDongs.Add(report);
            db.SaveChanges();
            return result != null;
        }
        private bool AddBaoCaoMatDoGuiXe(DateTime time, int XeVao, int XeRa)
        {
            int gio = time.Hour;
            time = time.Date;

            var list = db.BaoCaoMatDoGuiXes.Where(p => p.Ngay == time && p.Gio == gio).ToList();
            if (list.Count != 0)
                return true;
            BaoCaoMatDoGuiXe report = new BaoCaoMatDoGuiXe();
            report.TongXeVao = XeVao;
            report.Ngay = time;
            report.Gio = gio;
            report.TongXeRa = XeRa;
            report.ChenhLech = Math.Abs(XeVao - XeRa);
            var result = db.BaoCaoMatDoGuiXes.Add(report);
            db.SaveChanges();
            return result != null;
        }
        public bool GuiXe_BaoCaoMatDoGuiXe()
        {
            DateTime time = DateTime.Now.Date;
            int gio = DateTime.Now.Hour;
            var list = db.BaoCaoMatDoGuiXes.Where(p => p.Ngay == time && p.Gio == gio).ToList();
            if (list.Count == 0)
            {
                AddBaoCaoMatDoGuiXe(DateTime.Now, 1, 0);
                return true;
            }
            else
            {
                list[0].TongXeVao++;
                list[0].ChenhLech = Math.Abs(list[0].TongXeVao.Value - list[0].TongXeRa.Value);
                db.SaveChanges();
                return true;
            }
        }
        public bool NhanXe_BaoCaoMatDoGuiXe()
        {
            DateTime time = DateTime.Now.Date;
            int gio = DateTime.Now.Hour;
            var list = db.BaoCaoMatDoGuiXes.Where(p => p.Ngay == time && p.Gio == gio).ToList();
            if (list.Count == 0)
            {
                AddBaoCaoMatDoGuiXe(DateTime.Now, 0, 1);
                return true;
            }
            else
            {
                list[0].TongXeRa++;
                list[0].ChenhLech = Math.Abs(list[0].TongXeVao.Value - list[0].TongXeRa.Value);
                db.SaveChanges();
                return true;
            }
        }
        public bool AddBaoCaoDoanhThuThang(int idBaoCao, int nam, int Thang, int TongChi, int TongThu)
        {
            if (idBaoCao == -1)
                return false;
            BaoCaoDoanhThuThang report = new BaoCaoDoanhThuThang();
            report.Nam = nam;
            report.IDBaoCao = idBaoCao;
            report.TongChi = TongChi;
            report.Thang = Thang;
            report.TongThu = TongThu;
            report.ChenhLech = TongThu - TongChi;
            var result = db.BaoCaoDoanhThuThangs.Add(report);
            db.SaveChanges();
            return result != null;
        }
        public bool AddCT_BaoCaoLichSuHoatDong(int idBaoCao, DateTime Time, string BienSo)
        {
            if (idBaoCao == -1)
                return false;
            CT_BaoCaoLichSuHoatDong report = new CT_BaoCaoLichSuHoatDong();
            report.IDBaoCao = idBaoCao;
            report.BienSo = BienSo;
            report.ThoiGian = Time;
            var result = db.CT_BaoCaoLichSuHoatDong.Add(report);
            db.SaveChanges();
            return result != null;
        }

        public List<CT_BaoCaoLichSuHoatDong> GetCT_BaoCaoLichSuHoatDongs(DateTime? date = null)
        {
            var result = from c in db.CT_BaoCaoLichSuHoatDong
                         select c;

            if(date != null)
            {
                var l = (from c in db.BaoCaoLichSuHoatDongs
                         where c.Ngay == date
                         select c).ToList();

                int id1 = -1, id2 = -1;

                if (l.Count == 1)
                    id1 = l[0].IDBaoCao;

                if (l.Count == 2)
                    id2 = l[1].IDBaoCao;

                result = result.Where(p => p.IDBaoCao == id1 || p.IDBaoCao == id2);
            }

            return result.ToList();
        }
        public int GetIdBaoCaoLichSuHoatDong(DateTime time, int hoatDong)
        {
            var list = db.BaoCaoLichSuHoatDongs.Where(c => c.Ngay == time && hoatDong == c.HoatDong).ToList();
            if (list.Count == 0)
                return -1;
            return list[0].IDBaoCao;
        }

        public List<BaoCaoMatDoGuiXe> GetBaoCaoMatDoGuiXes(int? Thang = 0, int? Nam = 0)
        {
            var result = (from c in db.BaoCaoMatDoGuiXes
                          select c);
            if(Thang != 0 && Nam != 0)
            {
                result = result.Where(p => p.Ngay.Value.Month == Thang.Value && p.Ngay.Value.Year == Nam.Value);
            }
            if(Thang == 0 && Nam != 0)
            {
                result = result.Where(p => p.Ngay.Value.Year == Nam.Value);
            }
            return result.ToList();
        }

        public int AddBaoCaoTongThu()
        {
            var list = db.BaoCaoTongThus.Where(p => p.Thang == DateTime.Now.Month && p.Nam == DateTime.Now.Year).ToList();
            BaoCaoTongThu baocao;

            if (list.Count == 0)
            {
                baocao = new BaoCaoTongThu() { Nam = DateTime.Now.Year, Thang = DateTime.Now.Month };
                db.BaoCaoTongThus.Add(baocao);
                db.SaveChanges();
            }
            else
            {
                baocao = list.First();
            }
            return baocao.IDBaoCaoThu;
        }
        public int AddBaoCaoTongChi()
        {
            var list = db.BaoCaoTongChis.Where(p => p.Thang == DateTime.Now.Month && p.Nam == DateTime.Now.Year).ToList();
            BaoCaoTongChi baocao;

            if (list.Count == 0)
            {
                baocao = new BaoCaoTongChi() { Nam = DateTime.Now.Year, Thang = DateTime.Now.Month };
                db.BaoCaoTongChis.Add(baocao);
                db.SaveChanges();
            }
            else
            {
                baocao = list.First();
            }
            return baocao.IDBaoCaoChi;
        }

        public void AddCT_BaoCaoTongThu(int GiaTri, string HoatDong)
        {
            var baocao = db.BaoCaoTongThus.Where(p => p.Thang == DateTime.Now.Month && p.Nam == DateTime.Now.Year).ToList();
            int id;
            if (baocao.Count == 0)
                id = AddBaoCaoTongThu();
            else
                id = baocao.First().IDBaoCaoThu;
            CT_BaoCaoTongThu ct_baocao = new CT_BaoCaoTongThu() { IDBaoCao = id, GiaTri = GiaTri, HoatDong = HoatDong, ThoiGian = DateTime.Now };
            db.CT_BaoCaoTongThu.Add(ct_baocao);

            db.SaveChanges();
        }

        public void AddCT_BaoCaoTongChi(int GiaTri, string HoatDong)
        {
            var baocao = db.BaoCaoTongChis.Where(p => p.Thang == DateTime.Now.Month && p.Nam == DateTime.Now.Year).ToList();
            int id;
            if (baocao.Count == 0)
                id = AddBaoCaoTongChi();
            else
                id = baocao.First().IDBaoCaoChi;
            CT_BaoCaoTongChi ct_baocao = new CT_BaoCaoTongChi() { IDBaoCao = id, GiaTri = GiaTri, HoatDong = HoatDong, ThoiGian = DateTime.Now };
            db.CT_BaoCaoTongChi.Add(ct_baocao);

            db.SaveChanges();
        }
    }
}
