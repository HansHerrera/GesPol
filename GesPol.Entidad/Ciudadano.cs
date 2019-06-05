using System;
using System.Collections.Generic;
using System.Text;

namespace GesPol.Models
{
    public class Ciudadano
    {
        public Guid IdCiudadano { get; set; }
        public Guid IdTipoPersona { get; set; }
        public int Identidifacion { get; set; }
        public string Run { get; set; }
        public string Digito { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNac { get; set; }

        public string Nombres
        {
            get
            {
                return string.Concat(PrimerNombre, " ", SegundoNombre);
            }
        }
        public string RutCompleto
        {
            get
            {
                return string.Concat(Run, "-", Digito);
            }
        }


    }
}
