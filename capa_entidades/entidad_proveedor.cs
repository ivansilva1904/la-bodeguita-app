using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadProveedor
    {
        private long cuitProveedor;
        private string razonSocial;
        private string direccion;
        private string telefono;
        private string email;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private bool baja;

        public long CuitProveedor { get => cuitProveedor; set => cuitProveedor = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public bool Baja { get => baja; set => baja = value; }

    }
}
