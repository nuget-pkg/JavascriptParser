using JavascriptParser.Ast;

namespace JavascriptParser;

public interface IParser
{
    ParserOptions Options { get; }

    Script ParseScript(string input, int start, int length, string? sourceFile = null, bool strict = false);

    Module ParseModule(string input, int start, int length, string? sourceFile = null);

    Expression ParseExpression(string input, int start, int length, string? sourceFile = null, bool strict = false);
}
