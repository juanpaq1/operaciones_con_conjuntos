using System;
using Persona;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Lista_Conjunto
    {

        private List<Conjunto> _conjuntos;

        

        public Lista_Conjunto()
        {
            _conjuntos = new List<Conjunto>();
        }

        public void GuardarConjuntos(Conjunto conjunto)
        {
            _conjuntos.Add(conjunto);

        }

        public List<Conjunto> ObtenerConjunto()
        {
            return _conjuntos;

        }
    }
}
