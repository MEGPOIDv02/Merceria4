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
    
    public partial class Tarjetas
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Numero_Tarjeta { get; set; }
        public string Mes_Vencimiento { get; set; }
        public string Anio_Vencimiento { get; set; }
        public int Estado { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
