using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TableroIT.Juego.Personajes
{
  public  class JugadorPrincipal: Personaje
    {

        public JugadorPrincipal(string nombre) : base(nombre)
        {

        }

        public override  void  Mover()
        {
            int xAnterior = Posicion.X;
            int yAnterior = Posicion.Y;

            Posicion = new Posicion(xAnterior + 2, yAnterior + 2);
        }

    }
}
