using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models
{
    public class Unidad
    {

        public Guid IdUnidad { get; set; }
        public Guid IdReparticion { get; set; }
        public string UnidadNombre { get; set; }
        public int Estado { get; set; }
        
    }

}
