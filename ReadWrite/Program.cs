Console.Write("Escribe tu nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Escribe tu edad: ");
int edad = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Hola " + nombre + " tu edad es " + edad);