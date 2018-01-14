namespace ExampleProject.RealApplication.Services
{
    public sealed class RootWindow : IRootWindow
    {
        public RootWindow(IApplicationSettings applicationSettings)
        {

        }

        public void Show() => throw new System.NotImplementedException();
    }
}