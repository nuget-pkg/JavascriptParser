using System.Runtime.CompilerServices;
using JavascriptParser.Ast;

namespace JavascriptParser.Jsx.Ast;

public abstract class JsxElementOrFragment : JsxNode
{
    private readonly NodeList<JsxNode> _children;

    private protected JsxElementOrFragment(JsxNodeType type, in NodeList<JsxNode> children)
        : base(type)
    {
        _children = children;
    }

    public ref readonly NodeList<JsxNode> Children { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref _children; }
}
