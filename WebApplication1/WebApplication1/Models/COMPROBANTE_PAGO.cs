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
    
    public partial class COMPROBANTE_PAGO
    {
        public string COD_COMPROBANTE { get; set; }
        public string COD_ORDEN_ATENCION { get; set; }
        public string PLACA { get; set; }
        public string COD_TIPO_COMPRO { get; set; }
        public int DNI { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string OBSERVACIONES { get; set; }
        public string IMPORTE_TOT { get; set; }
        public Nullable<double> SUBTOTAL { get; set; }
        public Nullable<double> IGV { get; set; }
    
        public virtual C_AUTO C_AUTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ORDEN_ATENCION ORDEN_ATENCION { get; set; }
        public virtual TIPO_COMPROBANTE TIPO_COMPROBANTE { get; set; }
    }
}
