using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadTipoBebida
    {
        private int idTipoBebida;
        private string descripcion;

        public int IdTipoBebida { get => idTipoBebida; set => idTipoBebida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
