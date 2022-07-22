using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Abstraction
{
    public interface IAboutRepository
    {
        Task<List<About>> GetPicturePartId(int id);
        Task<List<About>> GetAll();
    }
}
