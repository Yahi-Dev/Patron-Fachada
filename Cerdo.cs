using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    internal class Cerdo
    {
        public Cerdo() { }
        public void cerdo()
        {
            Console.Write("Nombre del Animal: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Me llamo {nombre}, soy un Cerdo OINK ");
            Console.ReadKey();

        }
    }
}
