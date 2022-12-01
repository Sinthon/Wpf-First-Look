using Caliburn.Micro;
using System.Windows;
using Wpf_First_Look.ViewModels;

namespace Wpf_First_Look
{
    class Bootstapper : BootstrapperBase
    {
        public Bootstapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
