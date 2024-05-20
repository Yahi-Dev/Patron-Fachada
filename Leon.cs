using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    internal class Leon
    {
        public void leon()
        {
            Console.Write("Nombre del Animal: ");
            string nombre = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Me llamo {nombre}, soy un Leon RUAWWRRSSS \n \n \n");
            Console.ReadKey();
        }
    }
}
