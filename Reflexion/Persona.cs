using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metadatos.Reflexion {
    internal class Persona {
        public Persona() { }

        public Persona(string nombre) {
            Nombre = nombre;
        }

        public string? Nombre { get; }
    }
}
