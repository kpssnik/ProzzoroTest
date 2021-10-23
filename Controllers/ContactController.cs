using Microsoft.AspNetCore.Mvc;
using ProzzoroTest.Domain;
using ProzzoroTest.Domain.Repositories;
using ProzzoroTest.Service;
using System;
using System.IO;
using System.Linq;

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
                // Not the best idea but i can't imagine other
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

                // Appending model data to excel file while adding
                ExcelManager.AppendToExcel(model);

                return View("Thanks");
            }
            else
            {
                return View("Index");
            }
        }

        // Excel download button result
        [HttpGet]
        public FileResult DownloadExcel()
        {
            byte[] fileBytes = null;

            try
            {
                fileBytes = System.IO.File.ReadAllBytes(Config.ExcelPath);
            }
            catch (IOException)
            { }

            string fileName = Config.ExcelPath.Split('/').LastOrDefault();
            fileName ??= "Contact.xlsx";

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }


    }
}
