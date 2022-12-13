using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.Factories
{
    public interface ICalculateFactory
    {
        ICalculator Order();
    }
}