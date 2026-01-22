using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using JavascriptParser.Helpers;

namespace JavascriptParser.Ast;

[DebuggerDisplay($"{{{nameof(GetDebugDisplayText)}(), nq}}")]
public abstract partial class Node : INode, Global.IExportToCommonJson
{
    public string ExportToCommonJson()
    {
        return this.ToJson(indent: "  ");
    }
    public override string ToString()
    {
        return this.ToJson(indent: "  ");
    }
}
