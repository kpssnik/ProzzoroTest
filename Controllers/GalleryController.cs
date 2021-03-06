using Microsoft.AspNetCore.Mvc;
using ProzzoroTest.Domain;
using ProzzoroTest.Domain.Repositories;
using System;

namespace ProzzoroTest.Controllers
{
    public class GalleryController : Controller
    {
        private static AppDbContext _context = new AppDbContext();
        private GalleryImageRepository _galleryImageRepository = new GalleryImageRepository(_context);

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.GalleryImages = _galleryImageRepository.GetGalleryImages();
            return View();
        }
    }
}
