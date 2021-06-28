using System;

namespace Ies.Logo.Core
{
    public class LogoException : Exception
    {
        public LogoException() : base() { }
        public LogoException(string message) : base(message) { }
        public LogoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
