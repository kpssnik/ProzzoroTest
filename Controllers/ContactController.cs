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
        public ViewResult AddContact(Models.ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // Думаю не лучшая идея, но в голову другая не пришла
                _contactRepository.SaveContact(new Domain.Entities.Contact()
                {
                    FullName = model.FullName,
                    Age = model.Age,
                    Email = model.Email,
                    Experience = model.Experience,
                    Message = model.Message,
                    PhoneNumber = model.PhoneNumber,
                    IsValid = true
                });

                return View("Thanks!");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
