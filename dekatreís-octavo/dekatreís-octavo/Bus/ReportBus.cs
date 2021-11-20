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
        public bool AddBaoCaoDoanhThuThang(int nam, int loaiThe)
        {
            var list = db.BaoCaoDoanhThuThangs.Where(p => p.Nam == nam && p.LoaiThe == loaiThe).ToList();
            if (list.Count != 0)
                return true;
            BaoCaoDoanhThuThang report = new BaoCaoDoanhThuThang();
            report.LoaiThe = loaiThe;
            report.Nam = nam;
            var result = db.BaoCaoDoanhThuThangs.Add(report);
            db.SaveChanges();
            return result != null;
        }
        public bool AddBaoCaoMatDoGuiXe(DateTime time, int XeVao, int XeRa)
        {
            var list = db.BaoCaoMatDoGuiXes.Where(p => p.Ngay == time).ToList();
            if (list.Count != 0)
                return true;
            BaoCaoMatDoGuiXe report = new BaoCaoMatDoGuiXe();
            report.TongXeVao = XeVao;
            report.Ngay = time;
            report.Gio = time.Hour;
            report.TongXeRa = XeRa;
            report.ChenhLech = XeVao - XeRa;
            var result = db.BaoCaoMatDoGuiXes.Add(report);
            db.SaveChanges();
            return result != null;
        }
        public bool AddCT_BaoCaoDoanhThuThang(int idBaoCao, int Thang, int TongChi, int TongThu)
        {
            if (idBaoCao == -1)
                return false;
            CT_BaoCaoDoanhThuThang report = new CT_BaoCaoDoanhThuThang();
            report.IDBaoCao = idBaoCao;
            report.TongChi = TongChi;
            report.Thang = Thang;
            report.TongThu = TongThu;
            report.ChenhLech = TongThu - TongChi;
            var result = db.CT_BaoCaoDoanhThuThang.Add(report);
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
    }
}
