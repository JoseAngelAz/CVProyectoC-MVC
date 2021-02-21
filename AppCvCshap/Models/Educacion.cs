using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class Educacion
    {
        [Required(ErrorMessage = "Por favor ingrese un lugar de estudio")]
        public string Lugar { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string descripcion { get; set; }
    }
}