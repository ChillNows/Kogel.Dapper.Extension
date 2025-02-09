﻿using System;
using System.Data;
using Kogel.Dapper.Extension.Core.SetC;
using Kogel.Dapper.Extension.Core.SetQ;
using Kogel.Dapper.Extension.Model;

namespace Kogel.Dapper.Extension.Oracle
{
    public static class DataBase
    {
        public static QuerySet<T> QuerySet<T>(this IDbConnection sqlConnection, IDbTransaction dbTransaction = null)
        {
            return new QuerySet<T>(sqlConnection, new OracleSqlProvider(), dbTransaction);
        }

        public static CommandSet<T> CommandSet<T>(this IDbConnection sqlConnection, IDbTransaction dbTransaction = null)
        {
            return new CommandSet<T>(sqlConnection, new OracleSqlProvider(), dbTransaction);
        }
    }
}
