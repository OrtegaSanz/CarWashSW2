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
    
    public partial class DETALLE_ORDEN_ATENCION
    {
        public string COD_MATE { get; set; }
        public string PLACA { get; set; }
        public string COD_ORDEN_ATENCION { get; set; }
        public int DNI { get; set; }
    
        public virtual C_AUTO C_AUTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual MATERIALES MATERIALES { get; set; }
        public virtual ORDEN_ATENCION ORDEN_ATENCION { get; set; }
    }
}