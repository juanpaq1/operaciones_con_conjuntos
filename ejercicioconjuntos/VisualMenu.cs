using System;
using System.Collections.Generic;
using System.Linq;
using Logica;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Persona;
using System.Runtime.Serialization.Formatters;

namespace ejercicioconjuntos
{
    public class VisualMenu
    {
        char eleccion;  List<String> resultado = new List<String>();

        public void unirconjunto() 
        {
            Logica_conjuntos logica = new Logica_conjuntos();

            Conjunto ConjuntoA = new Conjunto(new List<string> { "juan", "sara", "maria" });
            Conjunto ConjuntoB = new Conjunto(new List<string> { "estefania", "sergio", "daniel" });

            while (true)
            {
                Console.WriteLine("¿Está seguro de su elección? S/N");
                string eleccion = Console.ReadLine();

                if (eleccion.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("OPERACIÓN CANCELADA");
                    return;
                }
                else if (eleccion.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida, por favor ingrese 'S' o 'N'.");
                }
            }

            List<string> resultado = logica.Union(ConjuntoB, ConjuntoA);

            Console.WriteLine("La unión de los conjuntos es:");
            for (int i = 0; i < resultado.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {resultado[i]}");
            }


        }
        public void interseccion()
        {
            Logica_conjuntos logica = new Logica_conjuntos();

            Conjunto ConjuntoA = new Conjunto(new List<string> { "juan", "sara", "maria" });
            Conjunto ConjuntoB = new Conjunto(new List<string> { "estefania", "sergio", "daniel","juan" });

            while (true)
            {
                Console.WriteLine("¿Está seguro de su elección? S/N");
                string eleccion = Console.ReadLine();

                if (eleccion.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("OPERACIÓN CANCELADA");
                    return;
                }
                else if (eleccion.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida, por favor ingrese 'S' o 'N'.");
                }
            }

            List<string> resultado = logica.Interseccion(ConjuntoB, ConjuntoA);

            Console.WriteLine("La INTERSECCION de los conjuntos es:");
            for (int i = 0; i < resultado.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {resultado[i]}");
            }


        }
        public void diferencia()
        {
            Logica_conjuntos logica = new Logica_conjuntos();

            Conjunto ConjuntoA = new Conjunto(new List<string> { "juan", "sara", "maria" });
            Conjunto ConjuntoB = new Conjunto(new List<string> { "estefania", "sergio", "daniel","juan" });

            while (true)
            {
                Console.WriteLine("¿Está seguro de su elección? S/N");
                string eleccion = Console.ReadLine();

                if (eleccion.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("OPERACIÓN CANCELADA");
                    return;
                }
                else if (eleccion.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida, por favor ingrese 'S' o 'N'.");
                }
            }

            List<string> resultado = logica.Diferencia(ConjuntoB, ConjuntoA);

            Console.WriteLine("La diferencia de los conjuntos es:");
            for (int i = 0; i < resultado.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {resultado[i]}");
            }


        }
    }
}
