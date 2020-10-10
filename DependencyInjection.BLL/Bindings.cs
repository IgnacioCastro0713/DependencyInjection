using DependencyInjection.BLL.Catalog;
using Ninject.Modules;

namespace DependencyInjection.BLL
{
    public class Bindings: NinjectModule
    {
        public override void Load()
        {
            Bind<IAppObject>().To<AppObject>();
        }
    }
}