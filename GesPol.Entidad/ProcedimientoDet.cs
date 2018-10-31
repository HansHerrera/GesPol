using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models
{
   public class ProcedimientoDet
    {
        public Guid IdProcedimientoDet { get; set; }
        public Guid IdProcedimiento { get; set; }
        public Guid IdTipoVehiculo { get; set; }
        public Guid IdTipoDroga { get; set; }
        

    }
}
