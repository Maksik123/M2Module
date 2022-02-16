using Autofac;
using M2Module.Interfaces;
using M2Module.Services;
using M2Module.Models;

namespace M2Module.Config
{
    public class DependencyConfig
    {
        public IContainer DependencyInjection()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<GenerateLineUp>().As<IGenerateLineUp>();
            containerBuilder.RegisterType<ManchesterUnited>().As<FootballTeam>();
            containerBuilder.RegisterType<GetGroupOfPlayers>().As<IGetGroupOfPlayers>();
            containerBuilder.RegisterType<Starter>();
            return containerBuilder.Build();
        }
    }
}
