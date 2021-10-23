using ProzzoroTest.Domain.Entities;
using System;
using System.Linq;

namespace ProzzoroTest.Domain.Repositories
{
    public class GalleryImageRepository
    {
        private readonly AppDbContext _context;

        public GalleryImageRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<GalleryImage> GetGalleryImages()
        {
            return _context.GalleryImages.OrderBy(p => p.Id);
        }


    }
}
