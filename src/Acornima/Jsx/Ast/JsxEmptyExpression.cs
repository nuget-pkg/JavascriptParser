using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor))]
public sealed partial class JsxEmptyExpression : JsxNode
{
    public JsxEmptyExpression()
        : base(JsxNodeType.EmptyExpression) { }
}
