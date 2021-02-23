using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CV
    {
        public DatosPersonales datapersonal = new DatosPersonales();
        public Educacion educacion = new Educacion();
        public FormacionTecnica formacionT = new FormacionTecnica();
        public ExperienciaLaboral expLaboral = new ExperienciaLaboral();
        public CompetenciasPersonales CPersonales = new CompetenciasPersonales();
        public CompetenciasProfesionales Cprofesionales = new CompetenciasProfesionales();
        public ReferenciasPersonales RefPersonal = new ReferenciasPersonales();
        public ReferenciasProfesionales RefProfesionales = new ReferenciasProfesionales();
    }
}