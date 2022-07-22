using PersonalPortfolio.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Abstract
{
    public interface IAboutPartService
    {
        Task<List<AboutDto>> GetPictureID(int id);
        Task<List<AboutDto>> GetAllPicture();
    }
}
