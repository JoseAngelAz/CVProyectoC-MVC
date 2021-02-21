using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CompetenciasPersonales
    {
        [Required(ErrorMessage = "Por favor ingrese una competencia personal")]
        public string competencia { get; set; }
    }
}