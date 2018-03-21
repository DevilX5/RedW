using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedW.Model.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string CName { get; set; }
        public DateTime? CooperationStart { get; set; }
        public DateTime? CooperationEnd { get; set; }
        public string Bz { get; set; }

    }
}
