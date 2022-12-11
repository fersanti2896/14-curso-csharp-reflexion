using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metadatos.Reflexion {
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class EsconderAttribute : Attribute {
        // Solamente podemos pasar los siguientes tipos de dato como parámetro:
        // Byte, Short, Integer, Long, Single, Double, Char, String, Boolean, System.Type, o una enumeración.

        public EsconderAttribute() {

        }

        public EsconderAttribute(int anioInicio, int mesInicio, int diaInicio, int anioFin, int mesFin, int diaFin) {
            FechaInicio = new DateTime(anioInicio, mesInicio, diaInicio);
            FechaFin = new DateTime(anioFin, mesFin, diaFin);
            usarRangoDeFecha = true;
        }

        public DateTime FechaInicio { get; }
        public DateTime FechaFin { get; }
        private bool usarRangoDeFecha = false;

        public bool Ocultar() {
            if (usarRangoDeFecha) {
                return DateTime.Now >= FechaInicio && DateTime.Now <= FechaFin;
            } else {
                return true;
            }
        }
    }
}
