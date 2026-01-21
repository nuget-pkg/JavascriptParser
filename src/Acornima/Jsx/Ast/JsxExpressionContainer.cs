using System.Runtime.CompilerServices;
using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor), ChildProperties = new[] { nameof(Expression) })]
public sealed partial class JsxExpressionContainer : JsxNode
{
    public JsxExpressionContainer(Expression expression)
        : base(JsxNodeType.ExpressionContainer)
    {
        Expression = expression;
    }

    public Expression Expression { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

    private JsxExpressionContainer Rewrite(Expression expression)
    {
        return new JsxExpressionContainer(expression);
    }
}
