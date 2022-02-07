using Autofac;
using M2Module.Config;

namespace M2Module
{
    public class Program
    {
        public static void Main()
        {
            DependecyInjection dependecyInjection = new DependecyInjection();
            var container = dependecyInjection.DependencyInjection();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}