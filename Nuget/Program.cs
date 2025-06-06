using System;
using Newtonsoft.Json;

public class Person
{
  public string? Name { get; set; }
  public int? Age { get; set; }
}

public class Program
{
  static void Main(string[] args)
  {
    var person = new Person
    {
      Name = "Anderson",
      Age = 23
    };

    string json = JsonConvert.SerializeObject(person);
    Console.WriteLine("Json serializado: " + json);

    var deserializacion = JsonConvert.DeserializeObject<Person>(json);
    Console.WriteLine($"Json deserializado: Name = {deserializacion!.Name} Age = {deserializacion!.Age}");

  }
}