﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class CardManagementBus
    {
        public bool AddCard(string ChuSoHuu, string TenXe, string BienSo, int LoaiThe)
        {
            TheXe the = new TheXe();
            the.ChuSoHuu = ChuSoHuu;
            the.TenXe = TenXe;
            the.BienSoXe = BienSo;
            the.LoaiThe = LoaiThe;
            the.NgayTao = DateTime.Now;
            TheXe result = DataProvider.Instance.db.TheXes.Add(the);
            DataProvider.Instance.db.SaveChanges();
            if (result == null)
                return false;
            else
                return true;
        }
        public bool EditCard(TheXe the, string ChuSoHuu, string TenXe, string BienSo, int LoaiThe)
        {
            the.ChuSoHuu = ChuSoHuu;
            the.TenXe = TenXe;
            the.BienSoXe = BienSo;
            the.LoaiThe = LoaiThe;
            //the.NgayTao = DateTime.Now;
            //TheXe result = DataProvider.Instance.db.TheXes.Add(the);
            DataProvider.Instance.db.SaveChanges();
            return true;
        }
        public bool DeleteCard(TheXe the)
        {
            DataProvider.Instance.db.TheXes.Remove(the);
            DataProvider.Instance.db.SaveChanges();
            return true;
        }
        public TheXe GetTheXeWithID(int id)
        {
            QuanLyDoXeEntities db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.IDThe == id
                         select c;
            return result.SingleOrDefault();
        }
        public IQueryable<TheXe> FindByChuSoHuu(string ChuSoHuu)
        {
            QuanLyDoXeEntities db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.ChuSoHuu.Contains(ChuSoHuu)
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByNgayTao(DateTime NgayTao)
        {
            QuanLyDoXeEntities db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.NgayTao == NgayTao
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByTenXe(string TenXe)
        {
            QuanLyDoXeEntities db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.TenXe.Contains(TenXe)
                         select c;
            return result;
        }
        public IQueryable<TheXe> FindByBienSo(string BienSo)
        {
            QuanLyDoXeEntities db = DataProvider.Instance.db;
            var result = from c in db.TheXes
                         where c.BienSoXe.Contains(BienSo)
                         select c;
            return result;
        }
    }
}
