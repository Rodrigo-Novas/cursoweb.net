using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TableroIT.Juego.Personajes
{
   public struct Posicion
    {
        public int X { get;}
        public int  Y { get;}


        public Posicion(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
