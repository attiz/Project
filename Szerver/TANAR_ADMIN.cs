//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szerver
{
    using System;
    using System.Collections.Generic;
    
    public partial class TANAR_ADMIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TANAR_ADMIN()
        {
            this.TANAR_TANTARGY = new HashSet<TANAR_TANTARGY>();
        }
    
        public short TA_ID { get; set; }
        public string TA_NEV { get; set; }
        public Nullable<byte> TSZ_ID { get; set; }
        public Nullable<byte> J_ID { get; set; }
    
        public virtual JOG JOG { get; set; }
        public virtual TANSZEK TANSZEK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TANAR_TANTARGY> TANAR_TANTARGY { get; set; }
    }
}
