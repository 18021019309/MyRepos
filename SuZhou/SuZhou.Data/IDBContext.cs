using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuZhou.Data
{
    public interface IDBContext
    {
        ISqlSugarClient sqlSugarClient { get; }
    }
}
