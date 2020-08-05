using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alumnos = new List<string>();
            List<string> alumnos2 = new List<string>() { "raul", "jose" }; //es lo mismo que hacer el add
            alumnos.Add("jorge");
            alumnos.Add("raul");
            alumnos.Add("jorge");

            foreach (var item in alumnos) //recorre primera lista
            {
                Console.WriteLine(item);

            }
            foreach (var item in alumnos2)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
        }
    }
}
