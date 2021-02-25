using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class FormacionTecnica
    {
        [Required(ErrorMessage = "Por favor ingrese el lugar donde se formo")]
        public string FormacionT  { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string DescripcionT { get; set; }
    }
}