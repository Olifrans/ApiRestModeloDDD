using Autofac;

namespace ApiRestModeloDDD.Infrastructure.CrossCuting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}