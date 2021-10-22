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
    public class HomeController : Controller
    {
        private static AppDbContext _context = new AppDbContext();
        private SkillItemRepository _skillItemRepository = new SkillItemRepository(_context);

        public IActionResult Index()
        {
            ViewBag.SkillItems = _skillItemRepository.GetSkillItems();
            return View();
        }
    }
}
