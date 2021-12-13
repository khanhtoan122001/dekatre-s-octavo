using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace dekatreís_octavo.Bus
{
    public class StaffViewBus
    {
        private static StaffViewBus instance;

        public static StaffViewBus Instance { get { if (instance == null) instance = new StaffViewBus(); return instance; } set => instance = value; }

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        public List<ListViewItem> SelectTaiKhoanListViewItem(List<TaiKhoan> list = null)
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            List<TaiKhoan> listTaiKhoan;
            if (list == null)
                listTaiKhoan = (from p in db.TaiKhoans select p).ToList();
            else
                listTaiKhoan = list;
            foreach (var TaiKhoan in listTaiKhoan)
            {
                if (TaiKhoan.LoaiTaiKhoan1.TenLoai == "admin")
                    continue;
                ListViewItem lvi = new ListViewItem(TaiKhoan.TenThat);
                lvi.SubItems.Add(TaiKhoan.CMND);
                lvi.SubItems.Add(TaiKhoan.SDT);
                if (TaiKhoan.LoaiTaiKhoan == LoaiTaiKhoanBus.Instance.GetIdByTen("admin"))
                    lvi.SubItems.Add("Admin");
                else
                    lvi.SubItems.Add("Nhân Viên");
                lvi.SubItems.Add(TaiKhoan.TenDangNhap);
                itemList.Add(lvi);
            }
            return itemList;
        }
        public void DeleteTaiKhoan(TaiKhoan selectedTaiKhoan)
        {
            db.TaiKhoans.Remove(selectedTaiKhoan);
            db.SaveChanges();
        }
        public TaiKhoan SelectTaiKhoan(string TenDangNhap)
        {
            TaiKhoan test = db.TaiKhoans.Where((p) => p.TenDangNhap == TenDangNhap).FirstOrDefault();
            return test;
        }
        public List<TaiKhoan> Search(string txt, int? sortType)
        {
            var result = from c in db.TaiKhoans
                         where c.LoaiTaiKhoan1.TenLoai == "staff"
                         select c;
            switch (sortType)
            {
                case -1:
                case 0:
                    result = result.Where(p => p.TenDangNhap.Contains(txt) || p.SDT.Contains(txt) || p.CMND.Contains(txt) || p.TenThat.Contains(txt));
                    break;
                case 1:
                    result = result.Where(p => p.TenDangNhap.Contains(txt));
                    break;
                case 2:
                    result = result.Where(p => p.TenThat.Contains(txt));
                    break;
                case 3:
                    result = result.Where(p => p.SDT.Contains(txt));
                    break;
                case 4:
                    result = result.Where(p => p.CMND.Contains(txt));
                    break;
            }
            

            return result.ToList();
        }
    }
}
