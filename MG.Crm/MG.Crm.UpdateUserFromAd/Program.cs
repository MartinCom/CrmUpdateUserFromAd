using MG.Crm.UpdateUserFromAd.Properties;
using System;
using System.DirectoryServices.AccountManagement;

namespace MG.Crm.UpdateUserFromAd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string domain = Settings.Default.DomainName;
            string container = Settings.Default.ContainerName;

            PrincipalContext context = new PrincipalContext(ContextType.Domain, domain, container);

            UserPrincipal userPrincipal = new UserPrincipal(context);
            PrincipalSearcher searchPrincipal = new PrincipalSearcher(userPrincipal);

            foreach (UserPrincipal result in searchPrincipal.FindAll())
            {
                Console.WriteLine(result.DisplayName);
            }
        }
    }
}