//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class movimientoStock
    {
        public int MovimientoStockId { get; set; }
        public int cantidad { get; set; }
        public bool entra { get; set; }
        public bool sale { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string descripcion { get; set; }
        public int StockId { get; set; }
        public Nullable<int> ComprobanteId { get; set; }
        public int TipoMovimientoStockId { get; set; }
    
        public virtual comprobante comprobante { get; set; }
        public virtual stock stock { get; set; }
        public virtual tipoMovimientoStock tipoMovimientoStock { get; set; }
    }
}
