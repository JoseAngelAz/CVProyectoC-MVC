using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class DatosPersonales
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un apellido")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su edad")]
        public int edad { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un telífono")]
        public int telefono { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una dirección")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su DUI")]
        public int dui { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su NIT")]
        public int nit { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su Fotografía")]
        public byte[] FotoPerfil { get; set; }
    }
}