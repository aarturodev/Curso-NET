int Suma(int numero1, int numero2)
{
  int result = numero1 + numero2;
  return result;
}

int Resta (int numero1, int numero2)
{
  int result = numero1 - numero2;
  return result;
}

int Multiplicacion(int numero1, int numero2)
{
  int result = numero1 * numero2;
  return result;
}

int Divicion(int numero1, int numero2 )
{
  if (numero2 == 0)
  {
    Console.WriteLine("No se puede dividir por cero !");
    return;
  }
  int result = numero1/numero2;
  return result;
  
}

Console.WriteLine($"La suma es: {Suma(3,10)}");
Console.WriteLine($"La Resta es: {Resta(20,10)}");
Console.WriteLine($"La Multi es: {Multiplicacion(3,3)}");
Console.WriteLine($"La Div es: {Divicion(10,2)}");