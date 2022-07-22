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
    public class EfHomePartRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;

        public EfHomePartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Home>> GetAll()
        {
            var explanation = await _context.Home.ToListAsync();
            return explanation;
        }

        public async Task<List<Home>> GetExplanationPartPartId(int id)
        {
            return await _context.Home.Where(a => a.Id == id).ToListAsync();
        }
    }
}
