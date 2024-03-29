using DispatcherDotNet.Run8.CustomInputClient.Exceptions;
using DispatcherDotNet.Run8.CustomInputClient.Interfaces;
using DispatcherDotNet.Run8.CustomInputClient.Run8;
using DispatcherDotNet.Run8.CustomInputClient.Services;
using DispatcherDotNet.Run8.CustomInputClient.Tests.TestData;

namespace DispatcherDotNet.Run8.CustomInputClient.Tests.Services
{
    public class Run8MessagingClientTests
    {

        private readonly IMessagingClient _messagingClient;

        public Run8MessagingClientTests()
        {
            _messagingClient = new Run8MessagingClient("127.0.0.1", 18888, false);
        }

        [Fact]
        public void CreateClient_ThrowsException_WhenNullIpAddress()
        {
            Assert.Throws<ArgumentNullException>(() => new Run8MessagingClient(string.Empty, 123));
        }

        [Fact]
        public void CreateClient_ThrowsException_WhenInvalidPort()
        {
            Assert.Throws<ArgumentNullException>(() => new Run8MessagingClient(string.Empty, -69));
        }

        [Theory]
        [ClassData(typeof(BrakeMessageInvalidTypes))]
        public void SendBrakeMessage_ThrowsException_WhenInvalidMessageType(EMessageType messageType)
        {
            Assert.Throws<InvalidMessageException>(() => _messagingClient.SendBrakeMessage(messageType, 69));
        }

        [Fact]
        public void SendBrakeMessage_ThrowsException_WhenValueIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => _messagingClient.SendBrakeMessage(EMessageType.TrainBrake, 512));
        }

        [Theory]
        [ClassData(typeof(ToggleMessageInvalidTypes))]
        public void SendToggleMessage_ThrowsException_WhenInvalidMessageType(EMessageType messageType)
        {
            Assert.Throws<InvalidMessageException>(() => _messagingClient.SendToggleMessage(messageType, false));
        }

        [Theory]
        [ClassData(typeof(CrcTestData))]
        public void CalculateCrc(EMessageType messageType, byte value, int expectedCrc)
        {
            var message = _messagingClient.GetMessage(messageType, value);

            Assert.Equal(expectedCrc, Run8MessagingClient.CalculateCrc(message));
        }
    }
}