using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.Protocols;
using System.Security.Authentication;
using System.Net;

namespace KossanVMS.Security
{

    public class AdAuthenticator
    {

        private const string AdServer = "kossan.com";
        private const int AdPort = 389;

        public bool AuthenticateUser(string username, string password)
        {
            string userDn = $"{username}@{AdServer}";
            try
            {
                var networkCredential = new NetworkCredential(userDn, password);
                using (var connection = new LdapConnection(AdServer + ":" + AdPort))
                {

                    connection.Credential = networkCredential;
                    connection.AuthType = AuthType.Basic;
                    connection.Timeout = new TimeSpan(0, 0, 10);
                    connection.Bind();
                    return true;
                }
            }
            catch(LdapException Ex)
            {
                return false;
            }
            catch ( Exception ex)
            {
                return false;
            }
        }
        public bool IsAdServerReachable()
        {
            try
            {
                using (var connection = new LdapConnection(AdServer + ":" + AdPort))
                {
                    connection.Timeout = new TimeSpan(0, 0, 5);
                    connection.Bind(); // Attempt to bind without credentials
                    return true; // If bind succeeds, server is reachable
                }
            }
            catch
            {
                return false; // Any exception means the server is not reachable
            }
        }
    }
}
