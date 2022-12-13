using vassilyev.autofuck.Implementations;
using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Factories
{
    public class CalculateFactory : ICalculateFactory
    {
        public ICalculator Order()
        {
            var printer = new Printer();
            var Logger = new Logger();
            var connector = new DatabaseConnector();
            var calculator = new Calculator(printer, connector);
            return calculator;
        }
    }
}