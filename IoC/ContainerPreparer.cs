using Autofac;

namespace vassilyev.autofuck.IoC
{
    static class ContainerPreparer
    {
        private static object _syncObject = new object();

        private static IContainer _container;
        private static ContainerBuilder _builder;

        public static IContainer Container
        {
            get
            {
                lock (_syncObject)
                {
                    return _container ??= Builder.Build();
                }
            }
        }

        public static ContainerBuilder Builder => _builder ??= new ContainerBuilder();
    }
}