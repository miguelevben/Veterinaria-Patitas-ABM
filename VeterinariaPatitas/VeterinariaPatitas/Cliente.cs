//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinariaPatitas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Domicilio { get; set; }
        public int IdProvincia { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCarga { get; set; }
        public System.DateTime FechaModificacion { get; set; }
    
        public virtual Provincia Provincia { get; set; }
        public virtual Mascota Mascota { get; set; }
    }
}