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
    
    public partial class TRUONGDH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUONGDH()
        {
            this.NGANHXT = new HashSet<NGANHXT>();
        }
    
        public string MaTruongDH { get; set; }
        public string TenTruong { get; set; }
        public string MaBGD { get; set; }
        public string MatKhau { get; set; }
    
        public virtual BoGD BoGD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGANHXT> NGANHXT { get; set; }
    }
}