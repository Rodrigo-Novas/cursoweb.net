using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeNegocio
{
    public class Categoria
    {

        private int id;
        private string nombre;
        private string descripcion;
        private byte[] Image { get; set; } //automimplementado

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }


        public string Nombre
        {

            get
            {
                return this.nombre
            }
            set
            {
                this.nombre = value;
            }
        }
        

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }

            set
            {
                this.descripcion = value;
            }
        }
    }
}
