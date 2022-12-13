using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Implementations
{
    public class Logger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine($"Вызван метод {nameof(Log)} класса {nameof(Logger)}");
        }
    }
}