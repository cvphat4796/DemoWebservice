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
    
    public partial class BoGD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoGD()
        {
            this.TRUONGDH = new HashSet<TRUONGDH>();
        }
    
        public string MaBGD { get; set; }
        public string TenBGD { get; set; }
        public string MatKhau { get; set; }
        public string MaQuyen { get; set; }
    
        public virtual PHANQUYEN PHANQUYEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUONGDH> TRUONGDH { get; set; }
    }
}