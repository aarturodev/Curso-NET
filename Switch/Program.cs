List<string> nombres = new List<string>();

nombres.Add("Arturo");
nombres.Add("Camila");
nombres.Add("Vanesa");
nombres.Add("Laura");
nombres.Add("Daniela");

switch (nombres[3])
{
  case "Arturo":
    Console.WriteLine("El nombre es Arturo");
    break;
  case "Camila":
    Console.WriteLine("El nombre es Arturo");
    break;
  case "Vanesa":
    Console.WriteLine("El nombre es Vanesa");
    break;
  case "Laura":
    Console.WriteLine("El nombre es Laura");
    break;
  case "Daniela":
    Console.WriteLine("El nombre es Daniela");
    break;
  default:
    Console.WriteLine("No se encontro ningun nombre");
    break;
}