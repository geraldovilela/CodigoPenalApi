using CodigoPenalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoPenalApi.Data
{
    public class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
        }
    }
    
    public class CriminalCodeCfg : IEntityTypeConfiguration<CriminalCode>
    {
        public void Configure(EntityTypeBuilder<CriminalCode> builder)
        {
            builder.ToTable("CriminalCode");
        }
    }
    
    public class StatusCfg : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
        }
    }

}
