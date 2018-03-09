using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedW.Model.User
{
    public class Menus
    {
        public int Id { get; set; }
        public int CurrendId { get; set; }
        public int ParentId { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string MenuName { get; set; }
    }
}
