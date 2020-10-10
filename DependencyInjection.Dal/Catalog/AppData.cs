namespace DependencyInjection.DAL.Catalog
{
    public class AppData: IAppdata
    {
        public string GetName()
        {
            return "Grizel";
        }
    }
    public interface IAppdata
    {
        string GetName();
    }
}