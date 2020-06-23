using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuZhou.Data.Impl.Models
{
    public class Menus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public int TypeId { get; set; }
    }
}
