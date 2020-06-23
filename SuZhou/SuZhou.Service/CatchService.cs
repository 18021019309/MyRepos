using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using SuZhou.Data.Impl.Models;

namespace SuZhou.Service
{
    public class CatchService : Base
    {
        public CatchService(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }

        public IList<Menus> GetMenu() => Function(x => x.Queryable<Menus>().ToList());
        
    }
}
