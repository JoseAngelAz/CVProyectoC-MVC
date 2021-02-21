using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class CV
    {
        DatosPersonales datapersonal = new DatosPersonales();
        Educacion educacion = new Educacion();
        FormacionTecnica formacionT = new FormacionTecnica();
        ExperienciaLaboral expLaboral = new ExperienciaLaboral();
        CompetenciasPersonales CPersonales = new CompetenciasPersonales();
        CompetenciasProfesionales Cprofesionales = new CompetenciasProfesionales();
        ReferenciasPersonales RefPersonal = new ReferenciasPersonales();
        ReferenciasProfesionales RefProfesionales = new ReferenciasProfesionales();
    }
}