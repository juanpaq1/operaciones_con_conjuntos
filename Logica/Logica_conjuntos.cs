using System;
using Persona;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_conjuntos
    {

        public List<string> Union(Conjunto conjuntoA, Conjunto conjuntoB)
        {
            // Assuming Conjunto has a List<string> called 'Elementos' that contains the set elements.
            var union = conjuntoA.nombres.Union(conjuntoB.nombres).ToList();
            return union;
        }

        public List<String> Interseccion(Conjunto A, Conjunto B)
        {
            var interseccion = A.nombres.Intersect(B.nombres).ToList();
            return interseccion;
        }

        public List<String> Diferencia(Conjunto A, Conjunto B)
        {
            var diferencia = A.nombres.Except(B.nombres).ToList();
            return diferencia;
        }


    }
    
}
