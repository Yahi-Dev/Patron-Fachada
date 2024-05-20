using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    internal class Caballo
    {
        public Caballo() { }

        public void caballo()
        {
            Console.Write("Nombre del Animal: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Me llamo {nombre}, soy un Caballo IJIIIII");
            Console.ReadKey();

        }
    }
}
