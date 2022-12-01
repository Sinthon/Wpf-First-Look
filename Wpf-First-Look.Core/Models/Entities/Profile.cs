using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_First_Look.Core.Models.Entities
{
    public class Profile
    {
        public string Id { get; set; } = string.Empty;

        public string BusinessPhones { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public string GivenName { get; set; } = string.Empty;

        public object JobTitle { get; set; } = string.Empty;

        public string Mail { get; set; } = string.Empty;

        public string MobilePhone { get; set; } = string.Empty;

        public string OfficeLocation { get; set; } = string.Empty;

        public string PreferredLanguage { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string UserPrincipalName { get; set; } = string.Empty;

        public string Photo { get; set; } = string.Empty;
    }
}
