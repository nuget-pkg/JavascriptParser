using System;
using JavascriptParser;
using static Global.EasyObjectClassic;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        //Echo(new { args = args });
        Echo(new { args });
        var parser = new Parser();
        JavascriptParser.Ast.Script ast = parser.ParseScript("console.log('Hello world!')");
        Echo(ast.ToJson(indent: "  "));
        Echo(ast.ToJavaScript());
        Echo(ast, "ast");
        Console.WriteLine(ast);
    }
}
