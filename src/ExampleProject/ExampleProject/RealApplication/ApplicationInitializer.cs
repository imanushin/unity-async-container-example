using System.IO;
using System.Threading.Tasks;
using ExampleProject.ContainerLibrary;
using ExampleProject.RealApplication.Services;

namespace ExampleProject.RealApplication
{
    public static class ApplicationInitializer
    {
        public static async Task<IRootWindow> WarmupServices()
        {
            var contaner = (IAsyncContainer) null;

            // RootWindow class is registered as before - we just ask container to put all fields into ctor
            contaner.RegisterInstance<IRootWindow, RootWindow>();

            // This services required loading in async mode, so let's register his asyncronus loader
            contaner.RegisterFactory(CreateRootWindowAsync);
            
            return await contaner.ServiceLocator.GetInstanceAsync<IRootWindow>();
        }

        private static async Task<IApplicationSettings> CreateRootWindowAsync(IServiceLocator serviceLocator)
        {
            var settingsLoader = await serviceLocator.GetInstanceAsync<ISettingsLoader>();

            var settingsData = await settingsLoader.LoadSettingsAsync();

            return new ApplicationSettings(settingsData);
        }
    }
}