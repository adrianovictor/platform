using System;

namespace Platform.Common.Exceptions
{
    public class ArgException : Exception
    {
        public object[] Args { get; protected set; }

        public ArgException()
        {
        }

        public ArgException(string message, object[] args = null)
            : base(message)
        {
            Args = args ?? new object[] {};
        }

        public static TException Throw<TException>(string message = "argument_exception", params object[] args) where TException : Exception
        {
            return (TException) Activator.CreateInstance(typeof(TException), message, args);
        }
    }
}