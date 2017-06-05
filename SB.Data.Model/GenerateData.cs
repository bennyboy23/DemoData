using Bogus;
using Bogus.Extensions;
using SB.CRM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SB.Data.Model
{
    public class GenerateData : IGenerateData
    {
        public List<Contact> ContactsList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using Bogus, this generates a random list of 50 leads to populate a CRM environment
        /// </summary>
        /// <returns></returns>
        public List<Lead> LeadsList()
        {

            var leads = new Faker<Lead>()
                .StrictMode(false)
                .RuleFor(l => l.Subject, l => l.Lorem.Sentence(10))
                .RuleFor(l => l.FirstName, l => l.Person.FirstName)
                .RuleFor(l => l.LastName, l => l.Person.LastName)
                .RuleFor(l => l.CompanyName, l => l.Company.CompanyName().ClampLength(max: 20))
                .RuleFor(l => l.MobilePhone, l => l.Person.Phone.ClampLength(max: 20));

            return leads.Generate(50).ToList();
        }

        public List<Account> AccountsList()
        {
            var accounts = new Faker<Account>()
                .StrictMode(false)
                .RuleFor(a => a.Description, a => a.Company.CatchPhrase())
                .RuleFor(a => a.Name, a => a.Company.CompanyName().ClampLength(max: 20))
                .RuleFor(a => a.Telephone1, a => a.Phone.PhoneNumber())
                .RuleFor(a => a.Address1_PostalCode, a => a.Address.ZipCode().ClampLength(max: 20));

            return accounts.Generate(20).ToList();
        }
    }
}
