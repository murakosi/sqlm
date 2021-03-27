﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace MasudaManager.Utility.Parsers
{
    public class AntlrSqlBaseListener : SQLiteBaseListener
    {
        public AntlrSqlBaseListener()
        {
            Contexts = new List<ParserRuleContext>();
        }

        public List<ParserRuleContext> Contexts { get; set; }

        public override void EnterSql_stmt(SQLiteParser.Sql_stmtContext context)
        {
            base.EnterSql_stmt(context);
            Contexts.Add(context);
        }
    }
}