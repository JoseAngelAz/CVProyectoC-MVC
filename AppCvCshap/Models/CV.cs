using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CV
    {   [Key]
        public int idCv { get; set; }
        //datos personales
        
        [Required(ErrorMessage = "Por favor ingrese un nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un apellido")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su edad")]
        public string edad { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un telífono")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una dirección")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su DUI")]
        public string dui { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su NIT")]
        public string nit { get; set; }
        
        public string PaginaWeb { get; set; }

        //fotografia de perfil
       // public byte[] FotoPerfil { get; set; }
        //cursos
        [Required(ErrorMessage = "Por favor ingrese un Curso")]
        public string Curso { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una descripción del curso")]
        public string DescripcionCurso { get; set; }
        //educacion
        [Required(ErrorMessage = "Por favor ingrese un lugar de estudio")]
        public string LugarEducacion { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string descripcion_educacion { get; set; }
        //competencias personales
        [Required(ErrorMessage = "Por favor ingrese una competencia personal")]
        public string competencia { get; set; }
        //conpetencias profesionales
        [Required(ErrorMessage = "Por favor ingrese una competencia profesional")]
        public string competenciasProfesionales { get; set; }
        //experiencia laboral
        [Required(ErrorMessage = "Por favor ingrese su cargo")]
        public string Cargo_exp { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion del cargo")]
        public string Descripcion_exp { get; set; }
        //formacion tecnica
        [Required(ErrorMessage = "Por favor ingrese el lugar donde se formo")]
        public string FormacionTecnica { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string DescripcionFT { get; set; }
        //referencias personales
        [Required(ErrorMessage = "Por favor ingrese la referencia uno")]
        public string ref_PERSONAL_UNO { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public string telefono_ref_PERSONAL_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia dos")]
        public string ref_PERSONAL_DOS { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public string telefono_ref_PERSONAL_dos { get; set; }
        //referencias profesionales
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional uno")]
        public string ref_prof_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia uno")]
        public string telefono_uno_profesional { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional dos")]
        public string ref_prof_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el telefono de la referencia dos")]
        public string telefono_dos_profesional { get; set; }

        //objetivo del CV#
        [Required(ErrorMessage = "Por favor ingrese el objetivo al que va orientado su CV#")]
        public string objetivoCV { get; set; }
    }
}