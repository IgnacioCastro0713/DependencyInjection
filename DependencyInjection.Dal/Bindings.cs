using DependencyInjection.DAL.Catalog;
using Ninject.Modules;

namespace DependencyInjectio.Dal
{
    public class Bindings: NinjectModule
    {
        public override void Load()
        {
            Bind<IAppdata>().To<AppData>();
        }
    }
}