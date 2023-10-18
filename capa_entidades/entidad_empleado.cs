using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadEmpleado
    {
        private int dniEmpleado;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private DateTime fechaIncorp;
        private DateTime fechaDeshab;
        private string direccion;
        private string telefono;
        private string email;
        private string contraseña;
        private int idTipoEmpleado;
        private bool baja;

        /*public EntidadEmpleado(int dniEmpleado, string nombre, string apellido, DateTime fechaNac, 
            DateTime fechaIncorp, string direccion, string telefono, string email, 
            string contraseña, int idTipoEmpleado, bool baja)
        {
            DniEmpleado = dniEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            FechaIncorp = fechaIncorp;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Contraseña = contraseña;
            IdTipoEmpleado = idTipoEmpleado;
            Baja = baja;
        }*/

        public int DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public DateTime FechaIncorp { get => fechaIncorp; set => fechaIncorp = value; }
        public DateTime FechaDeshab { get => fechaDeshab; set => fechaDeshab = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int IdTipoEmpleado { get => idTipoEmpleado; set => idTipoEmpleado = value; }
        public bool Baja { get => baja; set => baja = value; }
    }
}
