using System;

namespace DispatcherDotNet.Run8.CustomInputClient.Exceptions
{
    /// <summary>
    /// Exception thrown when an invalid message type is recieved by a method.
    /// </summary>
    public class InvalidMessageException : Exception
    {
        /// <inheritdoc/>
        public InvalidMessageException() { }

        /// <inheritdoc/>
        public InvalidMessageException(string message) : base(message) { }

        /// <inheritdoc/>
        public InvalidMessageException(string messsage, Exception innerException) : base(messsage, innerException) { }
    }
}