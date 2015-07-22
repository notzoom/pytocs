﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pytocs.CodeModel
{
    public class CodeContinueStatement : CodeStatement
    {
        public override T Accept<T>(ICodeStatementVisitor<T> visitor)
        {
            return visitor.VisitContinue(this);
        }
    }
}