using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Range(minimum: 18, maximum: 130)]
        public int Edad { get; set; }
    }
}
