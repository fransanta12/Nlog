//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logs
    {
        public int ID { get; set; }
        public string Level { get; set; }
        public string CallSite { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string InnerException { get; set; }
        public string AdditionalInfo { get; set; }
        public System.DateTime LoggedOnDate { get; set; }
    }
}
