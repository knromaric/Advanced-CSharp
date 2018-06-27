using System;

namespace Exceptions_Demo
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

    }
} 
