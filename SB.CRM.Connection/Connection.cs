using Microsoft.Xrm.Tooling.Connector;
using SB.Data.Model;

namespace SB.CRM.Connection
{
    public class Connection : IConnection
    {
        public SBCRMContext GetContext(string connectionString)
        {
            var client = new CrmServiceClient(connectionString);
            SBCRMContext context = new SBCRMContext(client);

            return context;
        }
    }
}