using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models
{
   public class Procedimiento
    {
        public Guid IdProcedimiento { get; set; }
        public Guid IdFuncionario { get; set; }
        public Guid IdTipoProd { get; set; }
        public int ProdEstado { get; set; }
    }
}
