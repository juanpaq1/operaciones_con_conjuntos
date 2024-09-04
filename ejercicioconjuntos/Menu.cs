using Persona;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioconjuntos
{
    public class Menu
    {
        public void opciones()
        {
            List<String> persona = new List<String>();

            

            int opc;
            do
            {
                VisualMenu visual = new VisualMenu();
                Console.WriteLine("____________________________");
                Console.WriteLine("MENU DE OPERACIONES CON CONJUNTOS");
                Console.WriteLine("1.union");
                Console.WriteLine("2.interseccion");
                Console.WriteLine("3.ENCONTRAR EN EL CONJUNTO");
                Console.WriteLine("0.salir");
                Console.WriteLine("____________________________");


                opc = int.Parse(Console.ReadLine());
               

                switch (opc)
                {
                    case 1: visual.unirconjunto(); break;
                    case 2: visual.interseccion(); break;
                    case 3: visual.diferencia(); break;

                }
            } while (opc!=0);
           

        }

    }
}
