
using metadatos.Reflexion;
using System.Collections;
using System.Reflection;

Console.WriteLine("¡REFLEXIÓN Y METADATOS!");

Type tipo = typeof(int);
Console.WriteLine(tipo);

int edad = 999;
Type tipoEdad = edad.GetType();

/* Instanciando una clase por tipo */
Type tipoP = typeof(Persona);
var persona = (Persona)Activator.CreateInstance(tipoP)!;

Console.WriteLine($"Persona instanciada por el type: { persona }");

var pathPersona = typeof(Persona).FullName;
Console.WriteLine($"Nombre completo: { pathPersona }");

var assemblyPersona = typeof(Persona).Assembly.GetName().Name!;
Console.WriteLine($"Assembly: { assemblyPersona }");

var stringPersona = (Persona)Activator.CreateInstance(assemblyPersona, pathPersona)!.Unwrap()!;
Console.WriteLine($"String: { stringPersona }");

var typePersona = (Persona)Activator.CreateInstance(typeof(Persona), new object[] { "Fer Santi" })!;
Console.WriteLine($"Nombre de la persona: { typePersona }\n");

/* Instanciando métodos */
var tipoUtil = typeof(Utilidades);
var utilidades = Activator.CreateInstance(tipoUtil)!;

tipoUtil.InvokeMember("ImprimirHoraActual", BindingFlags.InvokeMethod, binder: null, target: utilidades, args: new object[] { });
tipoUtil.InvokeMember("ImprimirMensaje", BindingFlags.InvokeMethod, binder: null, target: utilidades, args: new object[] { "Usando Reflexión" });
var resultado = tipoUtil.InvokeMember("ObteniendoUnValor", BindingFlags.InvokeMethod, binder: null, utilidades, new object[] { });

Console.WriteLine($"Obteniendo resultado: { resultado }");

tipoUtil.InvokeMember("MetodoEstatico", BindingFlags.InvokeMethod, binder: null, target: null, args: new object[] { });
tipoUtil.InvokeMember("MetodoPrivado", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, binder: null, target: utilidades, args: new object[] { });

/* Obteniendo tipo base e interfaz */
var baseString = typeof(string).BaseType;
var baseCarro = typeof(Carro).BaseType;

Console.WriteLine($"\nLa clase base de string es: { baseString }");
Console.WriteLine($"La clase base de carro es: { baseCarro }");
Console.WriteLine($"Las interfaces de string son: ");

foreach (var interfaz in typeof(string).GetInterfaces()) {
    Console.WriteLine($"- { interfaz }");
}

// Viendo si un tipo hereda de una interfaz o clase
var tipoString = typeof(string);
var tipoEnumerable = typeof(IEnumerable);
var tipoCarro = typeof(Carro);
var tipoVeh = typeof(Vehiculo);

Console.WriteLine($"\n¿String hereda de IEnumerable? { tipoString.IsAssignableTo(tipoEnumerable) }");
Console.WriteLine($"¿IEnumerable es implementada por String? { tipoEnumerable.IsAssignableFrom(tipoString) }");
Console.WriteLine($"¿Carro hereda de vehiculo? { tipoCarro.IsAssignableTo(tipoVeh) }");
Console.WriteLine($"¿Carro hereda de IEnumerable? { tipoCarro.IsAssignableTo(tipoEnumerable) }");

