using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models

{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public Guid IdFuncionario { get; set;  }
        public string rut { get; set; }
        public string password { get; set; }
    }
}
