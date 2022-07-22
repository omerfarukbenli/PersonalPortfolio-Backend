using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Abstraction
{
    public interface IHomeRepository
    {
        Task<List<Home>> GetExplanationPartPartId(int id);
        Task<List<Home>> GetAll();
    }
}
