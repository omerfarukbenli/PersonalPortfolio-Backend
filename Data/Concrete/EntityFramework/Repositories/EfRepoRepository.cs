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
    public class EfRepoRepository : IRepoRepository
    {
        private readonly ApplicationDbContext _context;

        public EfRepoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Repo>> GetAll()
        {
            var contact = await _context.Repo.ToListAsync();
            return contact;
        }

        public async Task<List<Repo>> GetTitlePartId(int id)
        {
            return await _context.Repo.Where(a => a.Id == id).ToListAsync();
        }
    }
}
