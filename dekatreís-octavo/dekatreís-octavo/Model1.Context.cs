﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dekatreís_octavo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyDoXeEntities1 : DbContext
    {
        public QuanLyDoXeEntities1()
            : base("name=QuanLyDoXeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaoCaoDoanhThuThang> BaoCaoDoanhThuThangs { get; set; }
        public virtual DbSet<BaoCaoLichSuHoatDong> BaoCaoLichSuHoatDongs { get; set; }
        public virtual DbSet<BaoCaoMatDoGuiXe> BaoCaoMatDoGuiXes { get; set; }
        public virtual DbSet<CT_BaoCaoDoanhThuThang> CT_BaoCaoDoanhThuThang { get; set; }
        public virtual DbSet<CT_BaoCaoLichSuHoatDong> CT_BaoCaoLichSuHoatDong { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThamSo> ThamSoes { get; set; }
        public virtual DbSet<TheXe> TheXes { get; set; }
        public virtual DbSet<LoaiThe> LoaiThes { get; set; }
        public virtual DbSet<BaoCaoChamCongNhanVien> BaoCaoChamCongNhanViens { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<BaoCaoTongChi> BaoCaoTongChis { get; set; }
        public virtual DbSet<BaoCaoTongThu> BaoCaoTongThus { get; set; }
        public virtual DbSet<CT_BaoCaoTongChi> CT_BaoCaoTongChi { get; set; }
        public virtual DbSet<CT_BaoCaoTongThu> CT_BaoCaoTongThu { get; set; }
    }
}
