using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeNegocio
{
    class Producto
    {


        public int Id { get; set; } //autoimplementadas
        public string Nombre { get; set; } 

        public decimal PrecioUnitario { get; set;} //es un decimal porque siempre que es un valor monetario se coloca como decimal


        public Categoria categoria { get; set; } //Relacion de composicion
        public Proveedor proveedor { get; set; }
    }
}
