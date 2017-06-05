using Microsoft.Xrm.Tooling.Connector;
using SB.Data.Model;
using System;
using System.Configuration;

namespace DemoData
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CrmServiceClient(ConfigurationManager.ConnectionStrings["CrmConnection"].ConnectionString);
            //var context = new SBCRMContext(client);

            var leads = new GenerateData().LeadsList();
            var accounts = new GenerateData().AccountsList();
            Console.WriteLine("leads intialised");
            foreach (var account in accounts)
            {
                client.Create(account);
                Console.WriteLine(account.Name);
            }
            foreach (var lead in leads)
            {

                client.Create(lead);
                Console.WriteLine(lead.FirstName + " Created");
            }
        }
    }
}
