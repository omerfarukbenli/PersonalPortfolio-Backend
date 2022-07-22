using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Abstraction
{
    public interface IRepoRepository
    {
        Task<List<Repo>> GetTitlePartId(int id); 
        Task<List<Repo>> GetAll();
    }
}
