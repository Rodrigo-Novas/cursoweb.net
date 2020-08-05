using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TableroIT.Juego.Personajes
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public Posicion Posicion { get; set; } //de tipo estructura

        public Personaje(string nombre)
        {
            this.Nombre = nombre;
        }

        public abstract void Mover();


        public override string ToString()
        {
            return $"Nombre: {Nombre} y Posicion {Posicion}";
        }

    }
}
