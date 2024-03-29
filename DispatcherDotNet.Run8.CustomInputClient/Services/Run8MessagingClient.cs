using DispatcherDotNet.Run8.CustomInputClient.Exceptions;
using DispatcherDotNet.Run8.CustomInputClient.Interfaces;
using DispatcherDotNet.Run8.CustomInputClient.Run8;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace DispatcherDotNet.Run8.CustomInputClient.Services
{
    /// <summary>
    /// Implmentation of <see cref="IMessagingClient"/> for use with Run8.
    /// </summary>
    public class Run8MessagingClient : IMessagingClient
    {
        private readonly UdpClient _udpClient;
        private readonly bool _useAudioBit = true;

        /// <summary>
        /// Creates a new instance of Run8MessagingClient.
        /// </summary>
        /// <remarks>
        /// By default, the messages constructed use the Audio Byte header.
        /// </remarks>
        /// <param name="ipAddress">The Ip Address that Run8 is listening on.</param>
        /// <param name="port">The Port that Run8 is expecting traffic on.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="ipAddress"/> is invalid.</exception>
        /// <exception cref="ArgumentException">If <paramref name="port"/> is invalid.</exception>
        public Run8MessagingClient(string ipAddress, int port)
        {
            if (string.IsNullOrEmpty(ipAddress))
            {
                throw new ArgumentNullException(nameof(ipAddress));
            }

            if (port < 0)
            {
                throw new ArgumentException(nameof(port));
            }

            _udpClient = new UdpClient(ipAddress, port);
        }

        /// <summary>
        /// Creates a new instance of Run8MessagingClient.
        /// </summary>
        /// <param name="ipAddress">The Ip Address that Run8 is listening on.</param>
        /// <param name="port">The Port that Run8 is expecting traffic on.</param>
        /// <param name="useAudioBit">Whether or not the Audio Header Byte should be used.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="ipAddress"/> is invalid.</exception>
        /// <exception cref="ArgumentException">If <paramref name="port"/> is invalid.</exception>
        public Run8MessagingClient(string ipAddress, int port, bool useAudioBit) : this(ipAddress, port)
        {
            _useAudioBit = useAudioBit;
        }

        /// <inheritdoc/>
        public void SendBrakeMessage(EMessageType messageType, ushort value)
        {
            if (!Constants.BrakeMessageTypes.Contains(messageType))
            {
                throw new InvalidMessageException(nameof(messageType));
            }

            if (value < 0 || value > 255)
            {
                throw new ArgumentException(nameof(value));
            }

            var message = GetMessage(messageType, (byte)value);
            SendMessageToRun8(message);
        }

        /// <inheritdoc/>
        public void SendToggleMessage(EMessageType messageType, bool isPressed)
        {
            if (Constants.BrakeMessageTypes.Contains(messageType) || Constants.MultiValueMessageTypes.Contains(messageType))
            {
                throw new InvalidMessageException(nameof(messageType));
            }

            var message = GetMessage(messageType, BitConverter.GetBytes(isPressed)[0]);
            SendMessageToRun8(message);
        }

        /// <inheritdoc/>
        public bool SendMessageToRun8(byte[] data)
        {
            try
            {
                _udpClient.Send(data, data.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to send message to Run8: {e.Message}");
                return false;
            }
            return true;
        }

        /// <inheritdoc/>
        public async Task<bool> SendMessageToRun8Async(byte[] data)
        {
            try
            {
                await _udpClient.SendAsync(data, data.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to send message to Run8: {e.Message}");
                return false;
            }
            return true;
        }

        /// <inheritdoc/>
        public byte[] GetMessage(EMessageType messageType, byte value)
        {
            byte[] message = new byte[5];
            message[0] = _useAudioBit ? Constants.AUDIO_HEADER : Constants.NON_AUDIO_HEADER;
            message[1] = 0; // This byte is currently unused in Run8, and will always be 0.
            message[2] = (byte)messageType;
            message[3] = (byte)value;
            message[4] = CalculateCrc(message);
            return message;
        }

        /// <inheritdoc/>
        public static byte CalculateCrc(byte[] data)
        {
            byte crc = data[0];
            for (int i = 1; i < data.Length - 1; i++)
            {
                crc = (byte)(crc ^ data[i]);
            }

            return crc;
        }
    }
}