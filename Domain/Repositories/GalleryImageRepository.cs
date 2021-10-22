using ProzzoroTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
