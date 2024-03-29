using DispatcherDotNet.Run8.CustomInputClient.Run8;
using DispatcherDotNet.Run8.CustomInputClient.Exceptions;
using System.Threading.Tasks;

namespace DispatcherDotNet.Run8.CustomInputClient.Interfaces
{
    /// <summary>
    /// Defines operations for sending messages to Run8.
    /// </summary>
    public interface IMessagingClient
    {
        /// <summary>
        /// Sends a toggle message to Run8.
        /// </summary>
        /// <param name="messageType">The type of message to be sent.</param>
        /// <param name="isPressed">Whether or not the control is pressed.</param>
        /// <remarks>
        /// This method is intended for use with message types that are on/off values.
        /// </remarks>
        /// <exception cref="InvalidMessageException">If an invalid message type was provided.</exception>
        public void SendToggleMessage(EMessageType messageType, bool isPressed);

        /// <summary>
        /// Sends a brake message to Run8.
        /// </summary>
        /// <param name="messageType">The type of message to be sent.</param>
        /// <param name="value">The position of the brake to set.</param>
        /// <exception cref="InvalidMessageException">If an invalid message type was provided.</exception>
        public void SendBrakeMessage(EMessageType messageType, ushort value);

        /// <summary>
        /// Sends a brake message to Run8 asynchronously.
        /// </summary>
        /// <param name="data">Data to be sent.</param>
        /// <returns></returns>
        public bool SendMessageToRun8(byte[] data);

        /// <summary>
        /// Sends a brake message to Run8 asynchronously.
        /// </summary>
        /// <param name="data">Data to be sent.</param>
        /// <returns></returns>
        public Task<bool> SendMessageToRun8Async(byte[] data);

        /// <summary>
        /// Constructs the data packet to be sent to Run8.
        /// </summary>
        /// <param name="messageType">The type of message being sent.</param>
        /// <param name="value">The value to send.</param>
        /// <returns>Constructed data packet for Run8.</returns>
        public byte[] GetMessage(EMessageType messageType, byte value);
    }
}