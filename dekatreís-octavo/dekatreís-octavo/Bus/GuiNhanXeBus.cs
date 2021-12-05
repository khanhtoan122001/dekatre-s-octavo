using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class GuiNhanXeBus
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        private static GuiNhanXeBus instance;

        public static GuiNhanXeBus Instance { get { if (instance == null) instance = new GuiNhanXeBus(); return instance; } set => instance = value; }
        #region
        public bool GuiXeThuong(int IDThe, string BienSo, string TenXe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            if (the == null || the.Status == false)
                return false;
            the.BienSoXe = BienSo;
            the.TenXe = TenXe;
            the.ThoiGianGui = DateTime.Now;
            the.Status = false;
            db.SaveChanges();
            // report
            if (ReportBus.Instance.AddBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Gửi xe").IDThamSo))
            {
                int idBaoCao = ReportBus.Instance.GetIdBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Gửi xe").IDThamSo);
                ReportBus.Instance.AddCT_BaoCaoLichSuHoatDong(idBaoCao, DateTime.Now, BienSo);
            }
            ReportBus.Instance.GuiXe_BaoCaoMatDoGuiXe();
            //
            return true;
        }
        public bool NhanXeThuong(int IDThe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            if (the == null || the.Status == true)
                return false;
            // hoa don
            LoaiTheBus.Instance.Update();
            HoaDonBus.Instance.AddHoaDon(the.BienSoXe, the.LoaiThe1.Gia.Value);
            //
            // report
            if (ReportBus.Instance.AddBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Nhận xe").IDThamSo))
            {
                int idBaoCao = ReportBus.Instance.GetIdBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Nhận xe").IDThamSo);
                ReportBus.Instance.AddCT_BaoCaoLichSuHoatDong(idBaoCao, DateTime.Now, the.BienSoXe);
            }
            ReportBus.Instance.NhanXe_BaoCaoMatDoGuiXe();
            //
            the.BienSoXe = "";
            the.TenXe = "";
            the.ThoiGianGui = null;
            the.Status = true;
            db.SaveChanges();
            return true;
        }
        public bool GuiXeTheThang(int IDThe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            if (the == null || the.Status == false)
                return false;
            the.ThoiGianGui = DateTime.Now;
            the.Status = false;
            db.SaveChanges();
            // report
            if (ReportBus.Instance.AddBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Gửi xe").IDThamSo))
            {
                int idBaoCao = ReportBus.Instance.GetIdBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Gửi xe").IDThamSo);
                ReportBus.Instance.AddCT_BaoCaoLichSuHoatDong(idBaoCao, DateTime.Now, the.BienSoXe);
            }
            ReportBus.Instance.GuiXe_BaoCaoMatDoGuiXe();
            //
            return true;
        }
        public bool NhanXeTheThang(int IDThe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            if (the == null || the.Status == true)
                return false;
            // hoa don
            LoaiTheBus.Instance.Update();
            HoaDonBus.Instance.AddHoaDon(the.BienSoXe, 0);
            //
            // report
            if (ReportBus.Instance.AddBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Nhận xe").IDThamSo))
            {
                int idBaoCao = ReportBus.Instance.GetIdBaoCaoLichSuHoatDong(DateTime.Now.Date, ThamSoBus.Instance.GetByTen("Nhận xe").IDThamSo);
                ReportBus.Instance.AddCT_BaoCaoLichSuHoatDong(idBaoCao, DateTime.Now, the.BienSoXe);
            }
            ReportBus.Instance.NhanXe_BaoCaoMatDoGuiXe();
            //
            the.Status = true;
            the.ThoiGianGui = null;
            db.SaveChanges();
            return true;
        }
        #endregion

        public List<TheXe> GetTheXesEnable()
        {
            return (from c in db.TheXes
                    where c.Status == true
                    select c).ToList();
        }
    }
}
