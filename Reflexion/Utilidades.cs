using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metadatos.Reflexion {
    internal class Utilidades {
        public void ImprimirHoraActual() {
            Console.WriteLine($"La hora actual es: { DateTime.Now }");
        }

        public void ImprimirMensaje(string mensaje) {
            Console.WriteLine($"Imprimiendo el mensaje del usuario: { mensaje }");
        }

        public string ObteniendoUnValor(){
            return "Fernando";
        }

        public static void MetodoEstatico() {
            Console.WriteLine("Ha sido invocado el método estático");
        }

        private void MetodoPrivado() {
            Console.WriteLine("Ha sido invocado el método privado");
        }
    }
}
