Console.Write("Escribe Tu Edad: ");
int edad = Convert.ToInt32(Console.ReadLine());



if (edad >= 18)
{
  Console.WriteLine("Eres Mayor de edad");
  Console.WriteLine("Ya pudes votar");
}
else
{
  Console.WriteLine("Eres Menor de Edad");
  Console.WriteLine("No puedes votar");

}