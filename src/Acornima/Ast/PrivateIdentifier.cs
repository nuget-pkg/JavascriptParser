using System.Runtime.CompilerServices;

namespace JavascriptParser.Ast;

[VisitableNode]
public sealed partial class PrivateIdentifier : Expression
{
    public PrivateIdentifier(string name)
        : base(NodeType.PrivateIdentifier)
    {
        Name = name;
    }

    public string Name { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
}
