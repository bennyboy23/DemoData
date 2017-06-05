using SB.CRM;
using System.Collections.Generic;

namespace SB.Data.Model
{
    public interface IGenerateData
    {
        List<Contact> ContactsList();
        List<Lead> LeadsList();
        List<Account> AccountsList();

    }
}
