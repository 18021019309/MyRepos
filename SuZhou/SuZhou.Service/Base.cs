using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuZhou.Service
{
    public class Base
    {
        private ISqlSugarClient sqlSugarClient;
        public Base(ISqlSugarClient sqlSugarClient)
        {
            this.sqlSugarClient = sqlSugarClient;
        }
        public T Function<T>(Func<ISqlSugarClient,T> func)
        {
           return func(sqlSugarClient);
        }
    }
}
