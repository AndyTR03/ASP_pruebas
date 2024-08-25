using System;
using System.Collections.Generic;

namespace MVCCRUD.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
}
