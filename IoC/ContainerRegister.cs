using Autofac;
using vassilyev.autofuck.Factories;
using vassilyev.autofuck.Implementations;
using vassilyev.autofuck.Interfaces;

namespace vassilyev.autofuck.IoC
{
    static class ContainerRegister
    {
        public static void Prepare(ContainerBuilder builder)
        {
            RegisterCalculator(builder);
        }

        public static void RegisterCalculator(ContainerBuilder builder)
        {
            builder.RegisterType<Printer>().As<IPrinter>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<Calculator>().As<ICalculator>();
            builder.RegisterType<CalculateFactory>().As<ICalculateFactory>();
        }
    }
}