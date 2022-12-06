using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf_First_Look.Core.Models.Entities;

namespace Wpf_First_Look.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {

        /// <summary>
        /// Fields
        /// </summary>
        private string message = "Default value";
        private BindableCollection<Profile> users = new();
        private Profile selectedUser = new();


        //Page
        private object dahsboardPage = new DashboardViewModel();
        private object customerPage = new CustomerViewModel();


        /// <summary>
        /// Properties
        /// </summary>
        public string Message
        {
            get => message;
            set
            {
                message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public BindableCollection<Profile> Users
        {
            get => users;
            set => users = value;
        }

        public Profile SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                NotifyOfPropertyChange(() => SelectedUser);
            }
        }

        public ShellViewModel()
        {
            users = new BindableCollection<Profile>()
            {
                new Profile()
                {
                    Id = Guid.NewGuid().ToString(),
                    BusinessPhones = "081968806,088967755",
                    DisplayName = "Sinthon",
                    GivenName = "",
                    JobTitle = "IT Programer",
                    Mail = "Sinthon@microsoft.com",
                    MobilePhone = "081968806",
                    OfficeLocation = "Siemreap",
                    PreferredLanguage = "en-US",
                    Surname = "Sinthon Seng",
                    UserPrincipalName = "",
                    Photo = ""
                },
                new Profile()
                {
                    Id = Guid.NewGuid().ToString(),
                    BusinessPhones = "081968806,088967755",
                    DisplayName = "Makara",
                    GivenName = "",
                    JobTitle = "IT Programer",
                    Mail = "Sinthon@microsoft.com",
                    MobilePhone = "081968806",
                    OfficeLocation = "Siemreap",
                    PreferredLanguage = "en-US",
                    Surname = "Sinthon Seng",
                    UserPrincipalName = "",
                    Photo = ""
                },
                new Profile()
                {
                    Id = Guid.NewGuid().ToString(),
                    BusinessPhones = "081968806,088967755",
                    DisplayName = "Vann thong",
                    GivenName = "",
                    JobTitle = "IT Programer",
                    Mail = "Sinthon@microsoft.com",
                    MobilePhone = "081968806",
                    OfficeLocation = "Siemreap",
                    PreferredLanguage = "en-US",
                    Surname = "Sinthon Seng",
                    UserPrincipalName = "",
                    Photo = ""
                },
            };

            this.ActiveItem = customerPage;
        }

        public void showDashboardPage()
        {
            this.ActiveItem = dahsboardPage;
        }

        public void showCustomerPage()
        {
            this.ActiveItem = customerPage;
        }
    }
}
