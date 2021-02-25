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
        [Required(ErrorMessage = "Por favor ingrese un teléfono")]
        public int telefono { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una dirección")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su DUI")]
        public int dui { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su NIT")]
        public int nit { get; set; }  
        public string PaginaWeb { get; set; }

        //redes sociales
        public string red_1 { get; set; }
        public string red_2 { get; set; }
        public string red_3 { get; set; }
        public string red_4 { get; set; }


        //fotografia de perfil
        [Required(ErrorMessage = "Por favor ingrese su fotografía")]
        public byte[] FotoPerfil { get; set; }
       
        //educacion
        [Required(ErrorMessage = "Por favor ingrese un lugar de estudio")]
        public string lugar_edu { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripción")]
        public string descripcion_edu { get; set; }
       
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
        public string descripcion_exp { get; set; }
       
        //formacion tecnica
        [Required(ErrorMessage = "Por favor ingrese el lugar donde se formo")]
        public string FormacionT { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la descripcion")]
        public string DescripcionT { get; set; }
       
        //referencias personales
        [Required(ErrorMessage = "Por favor ingrese la referencia uno")]
        public string ref_pers_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un contacto de la referencia uno")]
        public int contacto_pers_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia dos")]
        public string ref_pers_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un contacto de la referencia dos")]
        public int contacto_pers_dos { get; set; }
       
        //referencias profesionales
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional uno")]
        public string ref_prof_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un contacto de la referencia uno")]
        public int contacto_pro_uno { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la referencia profesional dos")]
        public string ref_prof_dos { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un contacto de la referencia dos")]
        public int contacto_pro_dos { get; set; }
    }
}