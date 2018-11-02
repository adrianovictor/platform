using System;
using System.Diagnostics;
using Platform.Common.Exceptions;
using Platform.Common.Extensions;

namespace Platform.Common.Utils
{
    public static class Ensure
    {
        /// <summary>
        /// Assegura que a condição dada seja verdadeira
        /// </summary>
        /// <param name="condition">Condição para teste</param>
        /// <param name="message">Chave do recurso para tradução</param>
        /// <param name="args">Argumentos usados para formatar a mensagem</param>
        /// <typeparam name="TException">Tipo da exceção</typeparam>
        public static void That<TException>(bool condition, string message = "argument_exception", params object[] args) 
            where TException : Exception
        {
            if (!condition)
            {
                if (typeof(TException).IsSubclassOf(typeof(ArgException)) || typeof(TException) == typeof(ArgException))
                    throw ArgException.Throw<TException>(message, args);

                if (message.IsNotNullOrEmpty())
                    throw (TException) Activator.CreateInstance(typeof(TException), message);

                throw (TException)Activator.CreateInstance(typeof(TException));
            }
        }

        public static void That(bool condition, string message = "argument_exception", params object[] args) => 
            That<ArgException>(condition, message, args);

        public static void Not<TException>(bool condition, string message = "", params object[] args) where TException : Exception => 
            That<TException>(!condition, message, args);  

        public static class Arg
        {
            
        }                  
    }
}
