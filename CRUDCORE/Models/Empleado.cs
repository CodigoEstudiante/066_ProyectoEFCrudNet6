using System;
using System.Collections.Generic;

namespace CRUDCORE.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo? oCargo { get; set; }
    }
}
