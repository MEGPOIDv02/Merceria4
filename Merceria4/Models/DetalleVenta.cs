//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Merceria4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVenta
    {
        public int Id { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public int Estado { get; set; }
    
        public virtual Ventas Ventas { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
