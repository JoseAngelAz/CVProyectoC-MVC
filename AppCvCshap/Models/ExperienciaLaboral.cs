 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class ExperienciaLaboral
    {
        [Required(ErrorMessage = "Por favor ingrese su cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion del cargo")]
        public string Descripcion { get; set; }
    }
}