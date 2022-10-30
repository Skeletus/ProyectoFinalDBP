using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace Web_D1M.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "El campo Nombre de  Usuario es Obligatorio")]
        public string NombreUser { get; set; } = null!;
        [Required(ErrorMessage = "El campo Email es Obligatorio")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "El campo Contraseña es Obligatorio")]
        public string PasswordUser { get; set; } = null!;
    }
}
