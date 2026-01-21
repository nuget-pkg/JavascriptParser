using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor))]
public sealed partial class JsxClosingFragment : JsxClosingTag
{
    public JsxClosingFragment()
        : base(JsxNodeType.ClosingFragment) { }
}
