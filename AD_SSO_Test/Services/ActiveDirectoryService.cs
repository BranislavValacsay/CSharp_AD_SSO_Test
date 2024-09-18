namespace AD_SSO_Test.Services
{
    using System;
    using System.DirectoryServices.Protocols;
    using System.Net;

    public class ActiveDirectoryService
    {
        private readonly string _ldapUrl;
        private readonly string _domain = "fqdn.of.domain";

        public ActiveDirectoryService(string ldapUrl)
        {
            _ldapUrl = ldapUrl;
        }

        public bool ValidateCredentials(string username, string password)
        {
            using (var connection = new LdapConnection(_ldapUrl))
            {
                connection.AuthType = AuthType.Basic;
                connection.SessionOptions.SecureSocketLayer = true;
                try
                {
                    connection.Bind(new NetworkCredential($"{username}@{_domain}", password));
                    return true;
                }
                catch (LdapException)
                {
                    return false;
                }
            }
        }
    }

}
