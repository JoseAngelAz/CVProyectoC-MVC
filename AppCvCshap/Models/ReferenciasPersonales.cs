using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class ReferenciasPersonales
    {
        [Required(ErrorMessage = "Por favor ingrese la referencia uno")]
        public string ref_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public int telefono_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia dos")]
        public string ref_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public int telefono_dos { get; set; }
        
    }
}