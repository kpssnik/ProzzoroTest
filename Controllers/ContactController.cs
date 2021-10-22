using Microsoft.AspNetCore.Mvc;
using ProzzoroTest.Domain;
using ProzzoroTest.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Controllers
{
    public class ContactController : Controller
    {
        private static AppDbContext _context = new AppDbContext();
        private ContactRepository _contactRepository = new ContactRepository(_context);

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }   

        [HttpPost]
        public ViewResult AddContact(Models.ContactModel contact)
        {
            return View("Index");
        }

    }
}
