using System.Threading.Tasks;

namespace ExampleProject.ContainerLibrary
{
    public interface IServiceLocator
    {
        // some of services can be registered in async mode. Therefore, we should use async method to get instance from container
        Task<TResult> GetInstanceAsync<TResult>();
    }
}