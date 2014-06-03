using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Office365.Exchange;
using Microsoft.Office365.OAuth;

namespace WinFormsOffice365
{
    public class Office365Contact
    {

        private const string ExchangeResourceId = "https://outlook.office365.com";
        private const string ExchangeServiceRoot = "https://outlook.office365.com/ews/odata";

        private ExchangeClient _exchangeClient;


        private bool _isAuthenticated = false;

        public bool IsAuthenticated 
        {
            get
            {
                return _isAuthenticated;
            }
        }


        private AuthenticationInfo _authenticationInfo;
        public AuthenticationInfo AuthenticationInfo
        {
            get { return _authenticationInfo; }
        }
        
        public async Task<ExchangeClient> EnsureExchangeClient()
        {
            if (_exchangeClient != null)
                return _exchangeClient;

            var authenticator = new Authenticator();
            _authenticationInfo = await authenticator.AuthenticateAsync(ExchangeResourceId);

            _exchangeClient = new ExchangeClient(new Uri(ExchangeServiceRoot), _authenticationInfo.GetAccessToken);
            _isAuthenticated = true;
            return _exchangeClient;
        }

        public async Task<IEnumerable<IContact>> GetAll()
        {
            var client = await EnsureExchangeClient();
            var contactsResults = await client.Me.Contacts.OrderBy(c => c.DisplayName).ExecuteAsync();
            return contactsResults.CurrentPage;
        }

        public async Task Create(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("contact");
            }
            var client = await EnsureExchangeClient();
            await client.Me.Contacts.AddContactAsync(contact);
        }

        public async Task SignOut()
        {
            _isAuthenticated = false;
            await new Authenticator().LogoutAsync();
        }

    }

}