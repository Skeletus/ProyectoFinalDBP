using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_D1M.Models
{
    public partial class Alumno
    {
        [Required(ErrorMessage ="El campo ID es Obligatorio")]
        public string IdAlumno { get; set; } = null!;
        [Required(ErrorMessage ="El campo APELLIDO PATERNO es Obligatorio")]
        public string? AluPaterno { get; set; }
        [Required(ErrorMessage = "El campo APELLIDO MATERNO es Obligatorio")]
        public string? AluMaterno { get; set; }
        [Required(ErrorMessage = "El campo NOMBRES es Obligatorio")]
        public string? AluNombres { get; set; }
        [Required(ErrorMessage ="El campo SEXO es Obligatorio")]
        public string? AluSexo { get; set; }
        [Required(ErrorMessage = "El campo CODIGO MODULAR es Obligatorio")]
        public string? AluCodigo { get; set; }
        [Required(ErrorMessage = "El campo ESTADO CIVIL es Obligatorio")]
        public string? IdEstadocivil { get; set; }
        [Required(ErrorMessage = "El campo EMAIL es Obligatorio")]
        public string? AluEmail { get; set; }
    }
}
