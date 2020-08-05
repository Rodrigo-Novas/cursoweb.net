using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TableroIT.Juego.Personajes;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            JugadorPrincipal jugaPrin = new JugadorPrincipal("Mario");
            JugadorCPU jugCPU = new JugadorCPU("Fantasmita");
            Naturaleza nat = new Naturaleza("pALOMA");
            Console.WriteLine("Ingrese el tamaño X");
            int.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine("Ingrese el tamaño y");
            int.TryParse(Console.ReadLine(), out int y);

            Tablero tab = new Tablero(x, y);

            tab.Personajes.Add(jugaPrin);
            tab.Personajes.Add(jugCPU);
            tab.Personajes.Add(nat);

            for(int i =0; i<100; i++)
            {

             Console.WriteLine(tab.MostrarPosiciones());
            }

            Console.ReadKey();
        }
    }
}
