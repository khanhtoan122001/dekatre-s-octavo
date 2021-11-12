using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using dekatreís_octavo.Model;

namespace dekatreís_octavo.DataAccess
{
    public class DataContext : DbContext
    {
        private static DataContext instance;
        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataContext();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataContext() : base("name=QuanLyDoXe") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<BaoCaoDoanhThuThang> BaoCaoDoanhThuThangs { get; set; }
        public virtual DbSet<BaoCaoLichSuHoatDong> BaoCaoLichSuHoatDongs { get; set; }
        public virtual DbSet<BaoCaoMatDoGuiXe> BaoCaoMatDoGuiXes { get; set; }
        public virtual DbSet<CT_BaoCaoDoanhThuThang> CT_BaoCaoDoanhThuThangs { get; set; }
        public virtual DbSet<CT_LichSuHoatDong> CT_LichSuHoatDongs { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThamSo> ThamSos { get; set; }
        public virtual DbSet<TheXe> TheXes { get; set; }
    }
}
