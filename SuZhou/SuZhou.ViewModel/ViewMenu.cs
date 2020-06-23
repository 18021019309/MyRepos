using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuZhou.ViewModel
{
    public class ViewMenu
    {
         public IList<ViewMenuItem> TopMenu { get; set; }
         public IList<ViewMenuItem> LeftMenu { get; set; }
    }
    public class ViewMenuItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public IList<ViewMenuItem> Nodes { get; set; }
    }
}
