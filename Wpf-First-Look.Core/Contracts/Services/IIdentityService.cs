using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_First_Look.Core.Helpers;

namespace Wpf_First_Look.Core.Contracts.Services
{
    public interface IIdentityService
    {
        event EventHandler LoggedIn;

        event EventHandler LoggedOut;

        void InitializeWithAadAndPersonalMsAccounts(string clientId, string redirectUri = null);

        void InitializeWithPersonalMsAccounts(string clientId, string redirectUri = null);

        void InitializeWithAadMultipleOrgs(string clientId, bool integratedAuth = false, string redirectUri = null);

        void InitializeWithAadSingleOrg(string clientId, string tenant, bool integratedAuth = false, string redirectUri = null);

        bool IsLoggedIn();

        Task<LoginResultType> LoginAsync();

        bool IsAuthorized();

        string GetAccountUserName();

        Task LogoutAsync();

        Task<string> GetAccessTokenForGraphAsync();

        Task<string> GetAccessTokenAsync(string[] scopes);

        Task<bool> AcquireTokenSilentAsync();
    }
}
