using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class Contexto: DbContext
    {
       public DbSet<DatosPersonales> datos_personales { get; set; }
       public DbSet<Educacion> educacion { get; set; }
       public DbSet<ExperienciaLaboral> experiencia_laboral { get; set; }
       public DbSet<FormacionTecnica> formacionT { get; set; }
       public DbSet<ReferenciasPersonales> ReferenciasP { get; set; }
       public DbSet<ReferenciasProfesionales> ReferenciasProfesionales { get; set; }


        //Prueba para CV#
        public DbSet<CV> CVsharp { get; set; }
        
        
    }
}