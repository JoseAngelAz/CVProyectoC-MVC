using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCvCshap.Models
{
    public class DatosPersonales
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int dui { get; set; }
        public int nit { get; set; }
    }
}