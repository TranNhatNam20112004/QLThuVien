//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int id { get; set; }
        public string maDH { get; set; }
        public int maSP { get; set; }
        public int soLuong { get; set; }
        public int tongTien { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual SanPham SanPham1 { get; set; }
    }
}
