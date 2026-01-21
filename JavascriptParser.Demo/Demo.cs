using JavascriptParser;
using Global;
using System;
using System.Reflection;
using static Global.EasyObjectClassic;

namespace Demo;

static class Program
{
    static void Main(string[] args)
    {
        Echo(new { args = args });
        var parser = new Parser();
        JavascriptParser.Ast.Script ast = parser.ParseScript("console.log('Hello world!')");
        Echo(ast.ToJson(indent: "  "));
        Echo(ast.ToJavaScript());
        //Type myType = ast.GetType();
        //MethodInfo myMethod = myType.GetMethod("ToJson");
        //var dyn = (dynamic)ast;
        //string result = dyn.ToJson();
        //Echo(result, "result(1)");
    }
}
