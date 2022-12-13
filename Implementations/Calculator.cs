using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Implementations
{
    public class Calculator : ICalculator
    {
        private readonly IPrinter _printer;
        private readonly IConnector _connector;

        public Calculator(IPrinter printer, IConnector connector)
        {
            this._printer = printer;
            this._connector = connector;
        }

        public void Calculate()
        {
            System.Console.WriteLine($"Метод {nameof(Calculate)} класса {nameof(Calculator)}");
            _connector.Connect();
            _printer.Print();
        }
    }
}