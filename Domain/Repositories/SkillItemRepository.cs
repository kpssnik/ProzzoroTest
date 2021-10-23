using ProzzoroTest.Domain.Entities;
using System;
using System.Linq;


namespace ProzzoroTest.Domain.Repositories
{
    public class SkillItemRepository
    {
        private readonly AppDbContext _context;

        public SkillItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<SkillItem> GetSkillItems()
        {
            return _context.SkillItems.OrderBy(p => p.Id);
        }
    }
}
