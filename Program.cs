
using metadatos.Reflexion;
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