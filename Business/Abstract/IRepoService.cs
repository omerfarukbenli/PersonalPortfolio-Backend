using PersonalPortfolio.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Abstract
{
    public interface IRepoService
    {
        Task<List<RepoDto>> GetTitletID(int id);
        Task<List<RepoDto>> GetAllTitle();
    }
}
