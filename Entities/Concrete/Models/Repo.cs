using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Entities.Concrete.Models
{
    public class Repo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string Link { get; set; }
    }
}
