using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_First_Look.Core.Models.Auth
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; } = string.Empty;
    }
}
