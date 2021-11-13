using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class GuiNhanXe
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        private static GuiNhanXe instance;

        public static GuiNhanXe Instance { get { if (instance == null) instance = new GuiNhanXe(); return instance; } set => instance = value; }

        public bool GuiXeThuong(int IDThe, string BienSo, string TenXe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            the.BienSoXe = BienSo;
            the.TenXe = TenXe;
            the.ThoiGianGui = DateTime.Now;
            the.Status = false;
            // report

            //
            db.SaveChanges();
            return true;
        }
        public bool NhanXeThuong(int IDThe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            // report
            
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
            the.ThoiGianGui = DateTime.Now;

            the.Status = false;
            // report

            //
            db.SaveChanges();
            return true;
        }
        public bool NhanXeTheThang(int IDThe)
        {
            TheXe the = db.TheXes.Find(IDThe);
            // report

            //
            the.Status = false;
            the.ThoiGianGui = null;
            db.SaveChanges();
            return true;
        }
    }
}
