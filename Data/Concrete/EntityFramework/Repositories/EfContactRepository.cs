using Microsoft.EntityFrameworkCore;
using PersonalPortfolio.Data.Abstraction;
using PersonalPortfolio.Data.Concrete.EntityFramework.Context;
using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Concrete.EntityFramework.Repositories
{
    public class EfContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public EfContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetAll()
        {
            var contact = await _context.Contact.ToListAsync();
            return contact;
        }

        public async Task<List<Contact>> GetContactPartId(int id)
        {
            return await _context.Contact.Where(a => a.Id == id).ToListAsync();
        }
    }
}
