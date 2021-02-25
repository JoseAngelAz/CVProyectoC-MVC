using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class Contexto: DbContext
    {
      
        //Prueba para CV#
        public DbSet<CV> CVsharp { get; set; }
        
        
    }
}