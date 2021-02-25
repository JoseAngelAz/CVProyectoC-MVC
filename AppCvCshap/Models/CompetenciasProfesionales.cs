using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CompetenciasProfesionales
    {
        [Required(ErrorMessage = "Por favor ingrese una competencia profesional")]
        public string competenciaProfesionales { get; set; }
        
    }
}