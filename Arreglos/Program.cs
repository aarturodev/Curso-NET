string[] nombres = new string[4]();

nombres[0] = "Anderson";
nombres[1] = "Sofia";
nombres[2] = "Oscar";
nombres[3] = "Felipe";
Console.WriteLine("Esto es un arreglo");
foreach (string nombre in nombres)
{
  Console.WriteLine(nombre);
}

List<string> nombres2 = new List<string>();

nombres2.Add("Arturo");
nombres2.Add("Camila");
nombres2.Add("vanesa");
nombres2.Add("laura");
nombres2.Add("Daniela");

Console.WriteLine("Esto es una lista");
foreach (string nombre in nombres2)
{
  Console.WriteLine(nombre);
}