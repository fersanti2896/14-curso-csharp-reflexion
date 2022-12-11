using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metadatos.Reflexion {
    internal enum Acciones {
        EscribirTXT = 1,
        [Esconder]
        EscribirXML = 2,
        [Esconder(anioInicio: 2023, mesInicio: 8, diaInicio: 18, anioFin: 2023, mesFin: 9, diaFin: 28)]
        EscribirJSON = 3
    }
}
