using System.Runtime.CompilerServices;
using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor))]
public sealed partial class JsxText : JsxNode
{
    public JsxText(string value, string raw)
        : base(JsxNodeType.Text)
    {
        Value = value;
        Raw = raw;
    }

    public string Value { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    public string Raw { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
}
