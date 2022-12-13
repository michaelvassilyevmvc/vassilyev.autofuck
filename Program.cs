using System;
using Autofac;
using vassilyev.autofuck.Factories;
using vassilyev.autofuck.Interfaces;
using vassilyev.autofuck.IoC;

namespace vassilyev.autofuck
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPrinterExample();
        }

        static void ShowPrinterExample()
        {
            using (var scope = PrepareContainer().BeginLifetimeScope())
            {
                var calculateFactory = scope.Resolve<ICalculateFactory>();
                calculateFactory.Order().Calculate();

            }
        }

        static IContainer PrepareContainer()
        {
            var builder = ContainerPreparer.Builder;
            ContainerRegister.Prepare(builder);
            return ContainerPreparer.Container;
        }
    }
}
