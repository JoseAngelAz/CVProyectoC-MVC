using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CV
    {
        public int IdCv { get; set; }
        //datos personales
        
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
        //fotografia de perfil
        public byte[] FotoPerfil { get; set; }
        //educacion
        [Required(ErrorMessage = "Por favor ingrese un lugar de estudio")]
        public string Lugar { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string descripcion { get; set; }
        //competencias personales
        [Required(ErrorMessage = "Por favor ingrese una competencia personal")]
        public string competencia { get; set; }
        //conpetencias profesionales
        [Required(ErrorMessage = "Por favor ingrese una competencia profesional")]
        public string competenciasProfesionales { get; set; }
        //experiencia laboral
        [Required(ErrorMessage = "Por favor ingrese su cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion del cargo")]
        public string Descripcion { get; set; }
        //formacion tecnica
        [Required(ErrorMessage = "Por favor ingrese el lugar donde se formo")]
        public string FormacionT { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string DescripcionT { get; set; }
        //referencias personales
        [Required(ErrorMessage = "Por favor ingrese la referencia uno")]
        public string ref_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public int telefono_uno_personal { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia dos")]
        public string ref_dos_personal { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public int telefono_dos { get; set; }
        //referencias profesionales
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional uno")]
        public string ref_prof_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public int telefono_uno_profesional { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional dos")]
        public string ref_prof_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public int telefono_dos_profesional { get; set; }
    }
}