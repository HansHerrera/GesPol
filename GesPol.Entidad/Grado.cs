using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models
{
    public class Grado
    {
        public Guid IdGrado { get; set; }
        public Guid IdEscalafon { get; set; }
        public string GradoNombre { get; set; }
        public int GradoEstado { get; set; }


    }
}
