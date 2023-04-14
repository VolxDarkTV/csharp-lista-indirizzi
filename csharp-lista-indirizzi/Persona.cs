using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Last { get; set; }

        public Persona(string name, string last)
        {
            if (name == "")
                throw new ArgumentNullException(nameof(name));
        }

    }
}
