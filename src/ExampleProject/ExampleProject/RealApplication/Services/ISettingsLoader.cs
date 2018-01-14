using System.Threading.Tasks;

namespace ExampleProject.RealApplication.Services
{
    public interface ISettingsLoader
    {
        Task<SettingsData> LoadSettingsAsync();
    }
}