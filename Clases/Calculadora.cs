namespace Operaciones
{
  public static class Calculadora
  {

    public static string Suma(int numero1, int numero2)
    {
      int result = numero1 + numero2;
      return resultadoOperacion(result);
    }

    public static string Resta(int numero1, int numero2)
    {
      int result = numero1 - numero2;
      return resultadoOperacion(result);
    }

    public static string Multiplicacion(int numero1, int numero2)
    {
      int result = numero1 * numero2;
      return resultadoOperacion(result);
    }

    public static string Divicion(int numero1, int numero2)
    {
      if (numero2 == 0)
        throw new DivideByZeroException("No se puede dividir por cero");
     
      int result = numero1 / numero2;
      return resultadoOperacion(result);

    }

    private static string resultadoOperacion(int resultado)
    {
      return $"El resultado de la operacione es: {resultado}";
    }
  }

}
