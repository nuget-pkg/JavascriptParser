using System.Runtime.CompilerServices;
using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

[VisitableNode(VisitorType = typeof(IJsxAstVisitor), ChildProperties = new[] { nameof(Name) })]
public sealed partial class JsxClosingElement : JsxClosingTag
{
    public JsxClosingElement(JsxName name)
        : base(JsxNodeType.ClosingElement)
    {
        Name = name;
    }

    /// <remarks>
    /// <see cref="JsxIdentifier"/> | <see cref="JsxNamespacedName"/> | <see cref="JsxMemberExpression"/>
    /// </remarks>
    public JsxName Name { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

    private JsxClosingElement Rewrite(JsxName name)
    {
        return new JsxClosingElement(name);
    }
}
