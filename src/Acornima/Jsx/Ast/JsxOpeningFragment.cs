using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor))]
public sealed partial class JsxOpeningFragment : JsxOpeningTag
{
    public JsxOpeningFragment()
        : base(JsxNodeType.OpeningFragment) { }

    private protected override bool GetSelfClosing() => false;
}
