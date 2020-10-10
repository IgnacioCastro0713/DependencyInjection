using DependencyInjection.DAL.Catalog;

namespace DependencyInjection.BLL.Catalog
{
    public class AppObject: IAppObject
    {
        private readonly IAppdata _appdata;

        public AppObject(IAppdata appdata)
        {
            _appdata = appdata;
        }
        public string GetName()
        {
            return _appdata.GetName();
        }
    }

    public interface IAppObject
    {
        string GetName();
    }
}