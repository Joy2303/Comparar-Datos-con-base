using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploMVC.Models
{
    public class Persona
    {

        [Key]
        public int idConsulta { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public string nombre { get; set; }

        public string fecha { get; set; }
        public string hora { get; set; }

    }
}
