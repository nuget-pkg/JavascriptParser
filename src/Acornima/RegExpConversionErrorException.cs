using System;

namespace JavascriptParser;

public sealed class RegExpConversionErrorException : ParseErrorException
{
    public RegExpConversionErrorException(RegExpConversionError error, Exception? innerException = null)
        : base(error, innerException) { }

    public new RegExpConversionError Error => (RegExpConversionError)base.Error;
}
