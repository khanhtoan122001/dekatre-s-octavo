using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class ThamSoBus
    {
        private static ThamSoBus instance;

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        public static ThamSoBus Instance { get { if (instance == null) instance = new ThamSoBus(); return instance; } set => instance = value; }

        public void SetDefaultThamSo()
        {
            if(db.ThamSoes.Count() == 0)
            {
                db.ThamSoes.Add(new ThamSo() {TenThamSo = "Gửi xe",GiaTri = 45 });
                db.ThamSoes.Add(new ThamSo() {TenThamSo = "Nhận xe",GiaTri = 49 });
            }
        }

        public int GetGiaTriByTen(string ten)
        {
            var thamso = db.ThamSoes.Where(p => p.TenThamSo == ten).ToList();
            if (thamso.Count == 0)
                return -1;
            return (int)thamso[0].GiaTri;
        }

        public bool AddThamSo(string ten, int giaTri)
        {
            if (db.ThamSoes.Where(p => p.TenThamSo == ten).Count() != 0)
                return false;
            ThamSo thamSo = new ThamSo();
            thamSo.TenThamSo = ten;
            thamSo.GiaTri = giaTri;
            var result = db.ThamSoes.Add(thamSo);
            db.SaveChanges();
            return result != null;
        }
        public bool EditThamSo(int idThamSo, string ten, int giaTri)
        {
            if (db.ThamSoes.Where(p => p.TenThamSo == ten).Count() != 0)
                return false;
            ThamSo thamSo = db.ThamSoes.Find(idThamSo);
            thamSo.TenThamSo = ten;
            thamSo.GiaTri = giaTri;
            var result = db.ThamSoes.Add(thamSo);
            db.SaveChanges();
            return result != null;
        }
        public bool RemoveThamSo(int idThamSo)
        {
            ThamSo thamSo = db.ThamSoes.Find(idThamSo);
            if (thamSo == null)
                return false;
            db.ThamSoes.Remove(thamSo);
            db.SaveChanges();
            return true;
        }
        public List<ThamSo> GetThamSos()
        {
            return (from c in db.ThamSoes
                    select c).ToList();
        }
    }
}
