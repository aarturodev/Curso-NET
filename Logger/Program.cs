ILogger consoleLogger = new ConsoleLogger();
ILogger fileLoger = new FileLogger();

consoleLogger.Log("Este es un menssage de log de consola");
fileLoger.Log("Este es un menssage de log en un archivo");