//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoConnectWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOCSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCSINH()
        {
            this.NGUYENVONG = new HashSet<NGUYENVONG>();
            this.PHANHOI = new HashSet<PHANHOI>();
        }
    
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiemMon1 { get; set; }
        public string DiemMon2 { get; set; }
        public string DiemMon3 { get; set; }
        public string DiemMon4 { get; set; }
        public string DiemMon5 { get; set; }
        public string MaTHPT { get; set; }
        public string MaKV { get; set; }
        public string MatKhau { get; set; }
        public string MaQuyen { get; set; }
    
        public virtual DIEMMH DIEMMH { get; set; }
        public virtual DIEMMH DIEMMH1 { get; set; }
        public virtual DIEMMH DIEMMH2 { get; set; }
        public virtual DIEMMH DIEMMH3 { get; set; }
        public virtual DIEMMH DIEMMH4 { get; set; }
        public virtual KHUVUC KHUVUC { get; set; }
        public virtual PHANQUYEN PHANQUYEN { get; set; }
        public virtual THPT THPT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUYENVONG> NGUYENVONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANHOI> PHANHOI { get; set; }
    }
}