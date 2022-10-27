using System;
using System.Collections.Generic;

namespace Web_D1M.Models
{
    public partial class Usuario
    {
        public string? UsuariorId { get; set; }
        public string? NombreUno { get; set; }
        public string? ApellidoUno { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string EmailUsario { get; set; } = null!;
        public string PasswordUsuariop { get; set; } = null!;
    }
}
