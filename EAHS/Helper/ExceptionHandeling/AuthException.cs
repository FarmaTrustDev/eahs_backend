using System;

namespace EAHS.Helper.ExceptionHendling
{
    public class AuthException : Exception
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public AuthException(string message)
            : base(message)
        {
            Success = false;
            Message = message;
        }
    }
}