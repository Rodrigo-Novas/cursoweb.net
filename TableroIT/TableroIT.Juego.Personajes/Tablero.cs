using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableroIT.Juego.Personajes
{
    public class Tablero
    {

        public int MaximoX { get; } = 1;
        public int MaximoY { get; } = 1;

        public List<Personaje> Personajes { get; } = new List<Personaje>();
        public Tablero(int x, int y)
        {
            this.MaximoX = x;
            this.MaximoY = y;
        }


        public void Mover()
        {

        }

        public string MostrarPosiciones()
        {
            StringBuilder sb = new StringBuilder(null);

            foreach(Personaje per in Personajes)
            {

                sb.AppendLine($"Nombre: {per.Nombre.ToString()}Posicion {per.Posicion.ToString()}"); //Nombre {per.Nombre.ToString()}

            }
            return sb.ToString();
        }


       
    }
}
