using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalPortfolio.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Configurations
{
    public class RepoConfiguration : IEntityTypeConfiguration<Repo>
    {
        public void Configure(EntityTypeBuilder<Repo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ContentSummary).IsRequired();
           
        }
    }
}
