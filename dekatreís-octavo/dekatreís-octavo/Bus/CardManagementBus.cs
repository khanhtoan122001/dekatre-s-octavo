using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class CardManagementBus
    {
        private static CardManagementBus instance;

        public static CardManagementBus Instance { get { if (instance == null) instance = new CardManagementBus(); return instance; } set => instance = value; }

        public bool AddCard(string ChuSoHuu, string TenXe, string BienSo, int LoaiThe)
        {
            TheXe the = new TheXe();
            the.ChuSoHuu = ChuSoHuu;
            the.TenXe = TenXe;
            the.BienSoXe = BienSo;
            the.LoaiThe = LoaiThe;
            the.NgayTao = DateTime.Now;
            the.Status = true;
            TheXe result = DataProvider.Instance.db.TheXes.Add(the);
            if (result == null)
                return false;
            DataProvider.Instance.db.SaveChanges();
            return true;
        }
        public bool EditCard(int IDthe, string ChuSoHuu, string TenXe, string BienSo, int LoaiThe)
        {
            TheXe the = DataProvider.Instance.db.TheXes.Find(IDthe);
            the.ChuSoHuu = ChuSoHuu;
            the.TenXe = TenXe;
            the.BienSoXe = BienSo;
            the.LoaiThe = LoaiThe;
            //the.NgayTao = DateTime.Now;
            //TheXe result = DataProvider.Instance.db.TheXes.Add(the);
            DataProvider.Instance.db.SaveChanges();
            return true;
        }
        public bool DeleteCard(int IDthe)
        {
            TheXe the = DataProvider.Instance.db.TheXes.Find(IDthe);
            DataProvider.Instance.db.TheXes.Remove(the);
            DataProvider.Instance.db.SaveChanges();
            return true;
        }
        public TheXe GetTheXeWithID(int id)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.IDThe == id
                         select c;
            return result.SingleOrDefault();
        }
        public IQueryable<TheXe> FindByChuSoHuu(string ChuSoHuu)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.ChuSoHuu.Contains(ChuSoHuu)
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByNgayTao(DateTime NgayTao)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.NgayTao == NgayTao
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByTenXe(string TenXe)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.TenXe.Contains(TenXe)
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByBienSo(string BienSo)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.BienSoXe.Contains(BienSo)
                         select c;
            return result;
        }
        public IQueryable<TheXe> GetTheXes(string sortType = null, string sortStatus = null)
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            
            var result = from c in db.TheXes
                   select c;
            if (sortType == "None")
                sortType = null;
            if (!string.IsNullOrEmpty(sortStatus))
            {
                bool status = sortStatus == "true" ? true : false;
                result = result.Where(p => p.Status == status);
            }
            if (!string.IsNullOrEmpty(sortType))
            {
                result = result.Where(p => p.LoaiThe1.TenLoai == sortType);
            }
            return result;
        }
        public void SetDefault()
        {
            QuanLyDoXeEntities1 db = DataProvider.Instance.db;
            if (db.TheXes.Count() < 19)
            {
                for (int i = 0; i < 10; i++)
                {
                    AddCard("", "", "", LoaiTheBus.Instance.GetIDTheByTen("Thẻ thường"));
                    AddCard("", "", "", LoaiTheBus.Instance.GetIDTheByTen("Thẻ tháng"));
                }
                db.SaveChanges();
            }

        }

        public void DangKyTheThang(int id, string bienso)
        {
            TheXe the = DataProvider.Instance.db.TheXes.Where(p => p.IDThe == id).FirstOrDefault();
            the.BienSoXe = bienso;
            the.NgayTao = DateTime.Now.Date;
            DataProvider.Instance.db.SaveChanges();
        }
    }
}
