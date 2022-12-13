using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Implementations
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            System.Console.WriteLine($"Вызван метод {nameof(Print)} из класса {nameof(Printer)}");
        }
    }
}