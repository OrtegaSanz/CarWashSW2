//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_AUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_AUTO()
        {
            this.COMPROBANTE_PAGO = new HashSet<COMPROBANTE_PAGO>();
            this.DETALLE_ORDEN_ATENCION = new HashSet<DETALLE_ORDEN_ATENCION>();
            this.ORDEN_ATENCION = new HashSet<ORDEN_ATENCION>();
            this.VENTAS_DIARIAS = new HashSet<VENTAS_DIARIAS>();
        }
    
        public string PLACA { get; set; }
        public int DNI { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string CLASE { get; set; }
        public Nullable<int> NUM_ASI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTE_PAGO> COMPROBANTE_PAGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ORDEN_ATENCION> DETALLE_ORDEN_ATENCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_ATENCION> ORDEN_ATENCION { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_DIARIAS> VENTAS_DIARIAS { get; set; }
    }
}
