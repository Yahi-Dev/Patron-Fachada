using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    internal class Gato
    {
        public Gato() { }

        public void gato()
        {
            Console.Write("Nombre del Animal: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Me llamo {nombre}, soy un gato MIUS");
            Console.ReadKey();

        }

    }
}
