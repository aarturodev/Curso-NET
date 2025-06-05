public class FileLogger : ILogger
{
  public void Log(string message)
  {
    // logica para gurdar el log en un archivo
    File.WriteAllText("log.txt", message);

  }
}