using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class LoaiTheBus
    {
        private static LoaiTheBus instance;

        public static LoaiTheBus Instance { get { if (instance == null) instance = new LoaiTheBus(); return instance; } set => instance = value; }

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        public bool AddLoaiThe(string ten, int gia)
        {
            if (db.LoaiThes.Where(p => p.TenLoai == ten).SingleOrDefault() != null)
                return false;
            LoaiThe loai = new LoaiThe();
            loai.TenLoai = ten;
            loai.Gia = gia;
            var result = db.LoaiThes.Add(loai);
            db.SaveChanges();
            return result != null;
        }
        public bool EditLoaiThe(int idLoaiThe, string ten, int gia)
        {
            LoaiThe loai = db.LoaiThes.Find(idLoaiThe);
            if (loai == null)
                return false;
            loai.TenLoai = ten;
            loai.Gia = gia;
            //var result = db.LoaiThes.Add(loai);
            db.SaveChanges();
            return true;
        }
        public bool RemoveLoaiThe(int idLoaiThe)
        {
            LoaiThe loai = db.LoaiThes.Find(idLoaiThe);
            if (loai == null)
                return false;
            db.LoaiThes.Remove(loai);
            db.SaveChanges();
            return true;
        }
        public void CheckLoaiThe()
        {
            if (db.LoaiThes.Count() == 0)
            {
                AddLoaiThe("Thẻ thường", 10000);
                AddLoaiThe("Thẻ tháng", 200000);
            }
        }
        public IQueryable<LoaiThe> GetLoaiThes()
        {
            var result = from c in db.LoaiThes
                         select c;
            return result;
        }
        public int GetIDTheByTen(string Ten)
        {
            return (db.LoaiThes.Where(p => p.TenLoai == Ten).SingleOrDefault().IDLoai);
        }
    }
}
