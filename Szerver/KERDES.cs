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
    
    public partial class KERDES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KERDES()
        {
            this.TANAR_TANTARGY = new HashSet<TANAR_TANTARGY>();
            this.VALASZOK = new HashSet<VALASZOK>();
        }
    
        public int K_ID { get; set; }
        public string KERDES1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TANAR_TANTARGY> TANAR_TANTARGY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VALASZOK> VALASZOK { get; set; }
    }
}
