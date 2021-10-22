using ProzzoroTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Domain.Repositories
{
    public class ContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Contact> GetContacts()
        {
            return _context.Contacts;
        }

        public void SaveContact(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
        }
    }
}
