//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace layout
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHD
    {
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> GIABAN { get; set; }
        public string MAKHUYENMAI { get; set; }
        public string MASANPHAM { get; set; }
        public string MAHOADON { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
