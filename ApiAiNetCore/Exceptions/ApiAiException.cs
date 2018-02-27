using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Exceptions
{
    public class ApiAiException : Exception
    {
        public string ResponseString { get; set; }

        public string RequestedUrl { get; set; }

        public ApiAiException(string response, string message) : base(message) { ResponseString = response; }

        public ApiAiException(string response, string message, Exception innerException) : base(message, innerException) { ResponseString = response; }

        //public ApiAiException(string response, Exception innerException) : base(innerException.Message, innerException) { ResponseString = response; }

        //public ApiAiException(Exception innerException) : base(innerException.Message, innerException) { }
    }
}
