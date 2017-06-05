using SB.Data.Model;

namespace SB.CRM.Connection
{
    public interface IConnection
    {
        SBCRMContext GetContext(string connectionString);
    }
}