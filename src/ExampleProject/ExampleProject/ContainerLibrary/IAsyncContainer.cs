using System;

namespace ExampleProject.ContainerLibrary
{
    public interface IAsyncContainer
    {
        // this is ordinal method, which asks container to create instance, based on constructor
        void RegisterInstance<TInterface, TImplementation>() where TImplementation : TInterface;

        // this method allows us to register non-blocking loading method
        void RegisterFactory<TInterface>(Func<IServiceLocator, TInterface> factory);

        IServiceLocator ServiceLocator { get; }
    }
}