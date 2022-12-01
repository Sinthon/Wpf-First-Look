using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Wpf_First_Look.Core.Contracts.Services;
using Wpf_First_Look.Core.Helpers;

namespace Wpf_First_Look.Core.Services
{
    public class IdentityService : IIdentityService
    {
        /*
        For more information about using Identity, see
        https://github.com/microsoft/WindowsTemplateStudio/blob/release/docs/WPF/services/identity.md

        Read more about Microsoft Identity Client here
        https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki
        https://docs.microsoft.com/azure/active-directory/develop/v2-overview

        TODO WTS: Please create a ClientID following these steps and update the appsettings.json IdentityClientId.
        https://docs.microsoft.com/azure/active-directory/develop/quickstart-register-app

        The provided clientID requests permissions on user.read, this might be blocked in environments that require admin consent.
        For more info about admin consent please see https://docs.microsoft.com/azure/active-directory/develop/application-consent-experience
        For more info creating protected APIs, see https://docs.microsoft.com/azure/active-directory/develop/scenario-protected-web-api-overview
        For more info on desktop apps that call protected APIs, see https://docs.microsoft.com/azure/active-directory/develop/scenario-desktop-overview
        */
        private readonly string[] _graphScopes = new string[] { "user.read" };
        private readonly IIdentityCacheService _identityCacheService;
        private bool _integratedAuthAvailable;

        public event EventHandler? LoggedIn;

        public event EventHandler? LoggedOut;

        public IdentityService(IIdentityCacheService identityCacheService)
        {
            _identityCacheService = identityCacheService;
        }

        public void InitializeWithAadAndPersonalMsAccounts(string clientId, string redirectUri = null)
        {
            _integratedAuthAvailable = false;
            

            ConfigureCache();
        }

        public void InitializeWithPersonalMsAccounts(string clientId, string redirectUri = null)
        {
            _integratedAuthAvailable = false;
            
            ConfigureCache();
        }

        public void InitializeWithAadMultipleOrgs(string clientId, bool integratedAuth = false, string redirectUri = null)
        {
            _integratedAuthAvailable = integratedAuth;
            
            ConfigureCache();
        }

        public void InitializeWithAadSingleOrg(string clientId, string tenant, bool integratedAuth = false, string redirectUri = null)
        {
            _integratedAuthAvailable = integratedAuth;
            
            ConfigureCache();
        }

        public bool IsLoggedIn() => true;

        public async Task<LoginResultType> LoginAsync()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return LoginResultType.NoNetworkAvailable;
            }

            try
            {
                

                LoggedIn?.Invoke(this, EventArgs.Empty);
                return LoginResultType.Success;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return LoginResultType.UnknownError;
            }
        }

        public bool IsAuthorized()
        {
            // TODO WTS: You can also add extra authorization checks here.
            // i.e.: Checks permisions of _authenticationResult.Account.Username in a database.
            return true;
        }

        public string GetAccountUserName()
        {
            return "Admin";
        }

        public async Task LogoutAsync()
        {
            try
            {
                
                LoggedOut?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception e)
            {
                // TODO WTS: LogoutAsync can fail please handle exceptions as appropriate to your scenario
                // For more info on MsalExceptions see
                // https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki/exceptions
            }
        }

        public async Task<string> GetAccessTokenForGraphAsync() => await GetAccessTokenAsync(_graphScopes);

        // All sensitive data in your app should be retrieven using access tokens.
        // This method provides you with an access token to secure calls to the Microsoft Graph or other protected API.
        // For more info on protecting web api with tokens see https://docs.microsoft.com/azure/active-directory/develop/scenario-protected-web-api-overview
        public async Task<string> GetAccessTokenAsync(string[] scopes)
        {
            return "";
        }

        public async Task<bool> AcquireTokenSilentAsync() => await AcquireTokenSilentAsync(_graphScopes);

        private async Task<bool> AcquireTokenSilentAsync(string[] scopes)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return false;
            }

            throw new NotImplementedException();
        }

        private void ConfigureCache()
        {
            if (_identityCacheService != null)
            {
                
            }
        }
    }
}
