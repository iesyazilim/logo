using Ies.Logo.Core;

namespace Ies.Logo.ServiceAdapter
{
    public class LogoObjectServiceException : LogoException
    {
        public string Xml { get; private set; }

        public LogoObjectServiceException() : base() { }
        public LogoObjectServiceException(string message, string xml = null) : base(message) 
        {
            Xml = xml;
        }
    }
}
