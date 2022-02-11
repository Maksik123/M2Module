using Autofac;
using M2Module.Config;

namespace M2Module
{
    public class Program
    {
        public static void Main()
        {
            DependencyConfig dependencyConfig = new DependencyConfig();
            var container = dependencyConfig.DependencyInjection();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}