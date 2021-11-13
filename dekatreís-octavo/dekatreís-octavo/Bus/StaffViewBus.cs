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
        public static QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        public List<ListViewItem> SelectTaiKhoanListViewItem()
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            var listTaiKhoan = (from p in db.TaiKhoans select p).ToList();
            foreach (var TaiKhoan in listTaiKhoan)
            {
                ListViewItem lvi = new ListViewItem(TaiKhoan.TenThat);
                lvi.SubItems.Add(TaiKhoan.CMND);
                lvi.SubItems.Add(TaiKhoan.SDT);
                if (TaiKhoan.LoaiTaiKhoan == 1)
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
    }
}
