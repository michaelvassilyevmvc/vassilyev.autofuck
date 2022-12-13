using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Implementations
{
    public class DatabaseConnector : IConnector
    {
        public void Connect()
        {
            System.Console.WriteLine($"Вызван метод {nameof(Connect)} из класса {nameof(DatabaseConnector)}");
        }
    }
}