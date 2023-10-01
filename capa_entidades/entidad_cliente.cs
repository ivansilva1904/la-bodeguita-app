using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadCliente
    {
        private int dniCliente;
        private string nombre;
        private string apellido;
        private string email;
        private DateTime fechaNac;
        private bool baja;

        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public bool Baja { get => baja; set => baja = value; }
    }
}
