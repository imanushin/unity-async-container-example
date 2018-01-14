using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProject.RealApplication;

namespace ExampleProject
{
    internal static class Program
    {
        private static void Main()
        {
            // In real life we will await this and close Splash screen after object will be ready
            var rootWindow = ApplicationInitializer.WarmupServices().Result;

            rootWindow.Show();
        }
    }
}
