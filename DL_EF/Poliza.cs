//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poliza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poliza()
        {
            this.EmpresaPolizas = new HashSet<EmpresaPoliza>();
            this.Vigencias = new HashSet<Vigencia>();
        }
    
        public int IdPoliza { get; set; }
        public string Nombre { get; set; }
        public Nullable<byte> IdSubPoliza { get; set; }
        public string NumeroPoliza { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaPoliza> EmpresaPolizas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vigencia> Vigencias { get; set; }
        public virtual SubPoliza SubPoliza { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
