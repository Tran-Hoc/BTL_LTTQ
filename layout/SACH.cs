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
    
    public partial class SACH
    {
        public string MASANPHAM { get; set; }
        public string LOAISACH { get; set; }
        public string TENTACGIA { get; set; }
        public Nullable<System.DateTime> NAMXUATBAN { get; set; }
        public string MOTA { get; set; }
        public string NHAXUATBAN { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}