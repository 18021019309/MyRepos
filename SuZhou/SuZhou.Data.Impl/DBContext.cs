using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace SuZhou.Data.Impl
{
    public class DBContext : IDBContext
    {
        public ISqlSugarClient sqlSugarClient
        {
            get
            {
                return new SqlSugarClient(new ConnectionConfig
                    {
                        AopEvents = new AopEvents
                        {

                        },
                        DbType = DbType.MySql,
                        IsAutoCloseConnection = true,
                        ConnectionString = ""
                    });
            }
        }
    }
}
