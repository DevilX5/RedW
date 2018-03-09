using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RedW.Model.Product
{
    public class Prices
    {
        [Description("编号")]
        public int Id { get; set; }
        [Description("产品编号")]
        public string ProId { get; set; }
        [Description("价格")]
        public decimal Pirce { get; set; }
    }
}
