﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_D1M.Models
{
    public partial class Usuario
    {
        public string? NombreReal { get; set; }
        public string? Apellido { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}