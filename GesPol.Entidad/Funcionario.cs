using System;


namespace GesPol.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public Guid Usuario { get; set; }

        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }        
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }

        public string Dni { get; set; }
        public string CodigoInterno { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRetiro { get; set; }

        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string EstadoCivil2 { get; set; }

        public Guid IdGrado { get; set; }

        

        public string Nombres
        {
            get
            {
                return string.Concat(PrimerNombre, " ",SegundoNombre);
            }
        }

        public string Apellidos
        {
            get
            {
                return string.Concat(ApellidoMaterno , " " ,ApellidoPaterno);
            }
        }



    }
}
