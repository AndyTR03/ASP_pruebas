using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        public string? Clave { get; set; }
    }
}
