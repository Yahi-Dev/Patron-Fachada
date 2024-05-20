using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    public class Factory
    {
        Fachada fachada = new Fachada();
        public void revolser (int opcion)
        {
            switch (opcion)
            {
                case 1: fachada.LLamarAnimalLeon(); break;

                case 2: fachada.LLamarAnimalGato(); break;

                case 3: fachada.LLamarAnimalPerro(); break;
            }
        }
    }
}
