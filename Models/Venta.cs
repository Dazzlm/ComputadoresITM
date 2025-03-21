//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputadoresITM.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int ComputadorID { get; set; }
        public int AgenciaID { get; set; }
        public Nullable<System.DateTime> FechaVenta { get; set; }
        public decimal Precio { get; set; }
        [JsonIgnore]
        public virtual Agencia Agencia { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
        [JsonIgnore]
        public virtual Computador Computador { get; set; }
    }
}
