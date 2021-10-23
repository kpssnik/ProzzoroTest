using ProzzoroTest.Domain.Entities;
using System;
using System.Linq;


namespace ProzzoroTest.Domain.Repositories
{
    public class NavigationItemRepository
    {
        private readonly AppDbContext _context;

        public NavigationItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<NavigationItem> GetNavigationItems()
        {
            return _context.NavigationItems.OrderBy(p => p.Id);
        }
    }
}
