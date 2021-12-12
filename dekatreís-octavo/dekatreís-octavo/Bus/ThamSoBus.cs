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
            //if(db.ThamSoes.Count() == 0)
            {
                AddThamSo("Gửi xe", 45);
                AddThamSo("Nhận xe", 49);
                AddThamSo("Lương", 4000000);
                AddThamSo("Tiền mặt bằng", 8000000);
                AddThamSo("Sức chứa", 200);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            foreach(var i in db.ThamSoes)
            {
                if(i.GiaTriMoi != null && i.NgayApDung <= DateTime.Now)
                {
                    i.GiaTri = i.GiaTriMoi;
                    i.GiaTriMoi = null;
                }
            }
            db.SaveChanges();
        }

        public ThamSo GetByTen(string ten)
        {
            var thamso = db.ThamSoes.Where(p => p.TenThamSo == ten).ToList();
            if (thamso.Count == 0)
                return null;
            return thamso[0];
        }

        public ThamSo GetById(int id)
        {
            var thamso = db.ThamSoes.Where(p => p.IDThamSo == id).ToList();
            if (thamso.Count == 0)
                return null;
            return thamso[0];
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
        public bool EditThamSo(string ten, int giaTri)
        {
            if (db.ThamSoes.Where(p => p.TenThamSo == ten).Count() == 0)
                return false;
            ThamSo thamSo = db.ThamSoes.Where(p => p.TenThamSo == ten).FirstOrDefault();
            thamSo.TenThamSo = ten;
            thamSo.GiaTri = giaTri;
            //var result = db.ThamSoes.Add(thamSo);
            db.SaveChanges();
            return true;
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
