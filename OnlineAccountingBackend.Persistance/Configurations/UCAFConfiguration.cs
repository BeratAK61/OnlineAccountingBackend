using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineAccountingBackend.Domain.CompanyEntities;
using OnlineAccountingBackend.Persistance.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingBackend.Persistance.Configurations
{
    public sealed class UCAFConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccounts);
            builder.HasKey(t => t.Id);
        }
    }
}
