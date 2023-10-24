using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadMarca
    {

        private int idMarca;
        private string descripcion;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
