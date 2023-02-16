using OnlineAccountingBackend.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingBackend.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }      //Ana Grup, Grup, Muavin
        public string CompanyId { get; set; }

    }
}
