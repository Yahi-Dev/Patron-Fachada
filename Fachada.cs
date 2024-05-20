using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada
{
    internal class Fachada
    {
        private Gato gato;
        private Leon leon;
        private Perro perro;

        public void LLamarAnimalLeon()
        {
            Leon leon = new Leon();
            leon.leon();
        }

        public void LLamarAnimalGato()
        {
           Gato gato = new Gato();
            gato.gato();
        }
        public void LLamarAnimalPerro()
        {
            perro = new Perro();
            perro.perro();
        }
    }
}
