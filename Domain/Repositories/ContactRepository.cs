using ProzzoroTest.Domain.Entities;
using System;
using System.Linq;


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
            return _context.Contacts.Where(p=>p.IsValid == true);
        }

        public void SaveContact(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
        }
    }
}
