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
    
    public partial class VENTAS_DIARIAS
    {
        public int NUM_VENTAS { get; set; }
        public string COD_MATE { get; set; }
        public string COD_SERVICIO { get; set; }
        public string PLACA { get; set; }
        public string COD_ORDEN_ATENCION { get; set; }
        public int DNI { get; set; }
        public Nullable<System.DateTime> FECHA_EMISION { get; set; }
        public string OBSERVACIONES { get; set; }
        public string IMPORTE_TOT { get; set; }
        public Nullable<double> SUBTOTAL { get; set; }
        public Nullable<double> IGV { get; set; }
    
        public virtual C_AUTO C_AUTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ORDEN_ATENCION ORDEN_ATENCION { get; set; }
    }
}
