using System.Runtime.CompilerServices;
using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor), ChildProperties = new[] { nameof(Argument) })]
public sealed partial class JsxSpreadAttribute : JsxAttributeLike
{
    public JsxSpreadAttribute(Expression argument)
        : base(JsxNodeType.SpreadAttribute)
    {
        Argument = argument;
    }

    public Expression Argument { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

    private JsxSpreadAttribute Rewrite(Expression argument)
    {
        return new JsxSpreadAttribute(argument);
    }
}
