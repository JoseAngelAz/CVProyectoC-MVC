using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class ReferenciasProfesionales
    {
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional uno")]
        public string ref_prof_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public int telefono_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional dos")]
        public string ref_prof_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public int telefono_dos { get; set; }
       
    }
}