namespace JavascriptParser.Ast;

[VisitableNode]
public sealed partial class ThisExpression : Expression
{
    public ThisExpression()
        : base(NodeType.ThisExpression) { }
}
