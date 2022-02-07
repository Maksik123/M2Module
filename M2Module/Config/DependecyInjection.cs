﻿using Autofac;
using M2Module.Interfaces;
using M2Module.Services;
using M2Module.Models;

namespace M2Module.Config
{
    public class DependecyInjection
    {
        public IContainer DependencyInjection()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<GenerateLineUp>().As<IGenerateLineUp>();
            containerBuilder.RegisterType<ManchesterUnited>().As<FootballTeam>();
            containerBuilder.RegisterType<Starter>();
            return containerBuilder.Build();
        }
    }
}
