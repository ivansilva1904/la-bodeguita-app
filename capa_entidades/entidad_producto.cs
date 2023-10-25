using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class EntidadProducto
    {
        private int idProducto;
        private string descripcion;
        private int idMarca; 
        private float precioCompra;
        private float precioVenta;
        private int stockMinimo;
        private int stockActual;
        private long cuitProveedor;
        private int idTipoBebida;
        private bool baja;

        
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public float PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public long CuitProveedor { get => cuitProveedor; set => cuitProveedor = value; }
        public int IdTipoBebida { get => idTipoBebida; set => idTipoBebida = value; }
        public bool Baja { get => baja; set => baja = value; }
    }
}
