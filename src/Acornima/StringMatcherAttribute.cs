using System;

namespace JavascriptParser;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
internal class StringMatcherAttribute : Attribute
{
    public StringMatcherAttribute(params string[] targets)
    {
        Targets = targets;
    }

    public string[] Targets { get; }
}
