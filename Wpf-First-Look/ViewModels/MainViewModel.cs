using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_First_Look.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        private object statupPage = new ShellViewModel();

        public MainViewModel()
        {
            this.ActiveItem = new ShellViewModel();
        }
    }
}
