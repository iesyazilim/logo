using System;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceException : Exception
    {
        public string Xml { get; private set; }

        public LogoObjectServiceException() : base() { }
        public LogoObjectServiceException(string message, string xml = null) : base(message) 
        {
            Xml = xml;
        }
    }
}
