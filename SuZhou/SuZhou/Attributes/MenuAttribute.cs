using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuZhou.Attributes
{
    public class MenuAttribute: Attribute
    {
        public MenuAttribute(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}