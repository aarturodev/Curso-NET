List<string> listaNombres = new List<string>();
List<string> listaApellidos = new List<string>();

listaNombres.Add("Anderson");
listaNombres.Add("Arturo");
listaNombres.Add("Camilo");
listaNombres.Add("Sofia");

listaApellidos.Add("Marin");
listaApellidos.Add("Chaves");
listaApellidos.Add("Lopez");
listaApellidos.Add("Rojas");

foreach (string nombre in listaNombres)
{
  foreach (string apellido in listaApellidos)
  {
    Console.WriteLine($"{nombre} {apellido}");
  }
}