using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Conjunto
    {
        public List<String> nombres {  get; set; }

        public Conjunto()
        {
            nombres = new List<String>();
        }
        public  Conjunto(List<String> nombres)
        {
            this.nombres = nombres;
        }
    }
}
