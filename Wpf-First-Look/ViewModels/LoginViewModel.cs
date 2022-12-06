using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf_First_Look.Core.Models.Auth;

namespace Wpf_First_Look.ViewModels
{
    internal class LoginViewModel : Screen
    {
        public User User { get; set; } = new();
    }
}
