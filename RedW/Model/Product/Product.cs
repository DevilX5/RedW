using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RedW.Model.Product
{
    public class Product
    {
        [Description("编号")]
        public int Id { get; set; }
        [Description("产品编号")]
        public string ProId { get; set; }
        [Description("商品名称")]
        public string ProName { get; set; }
        [Description("图片地址")]
        public string Url { get; set; }
        [Description("库存")]
        public string ProInventory { get; set; }
    }
}
