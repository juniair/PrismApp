using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismApp.Views;
using System.Windows;

namespace PrismApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
