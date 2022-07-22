using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Abstraction
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetContactPartId(int id);
        Task<List<Contact>> GetAll();
    }
}
