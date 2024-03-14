﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entities
{

    public class Usuario
    {
        [Key]
        public decimal UsuID { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }
}
