using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string CompanyId { get; set; }  =string.Empty;
        public string FullNames { get;set; }
    }
}
