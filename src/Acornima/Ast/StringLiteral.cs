using System.Runtime.CompilerServices;

namespace JavascriptParser.Ast;

public sealed class StringLiteral : Literal
{
    public StringLiteral(string value, string raw)
        : base(TokenKind.StringLiteral, raw)
    {
        Value = value;
    }

    public new string Value { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

    protected override object? GetValue() => Value;
}
