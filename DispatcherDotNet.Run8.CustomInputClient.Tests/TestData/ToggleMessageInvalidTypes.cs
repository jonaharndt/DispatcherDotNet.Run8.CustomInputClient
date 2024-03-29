using DispatcherDotNet.Run8.CustomInputClient.Run8;
using System;
using System.Collections;

namespace DispatcherDotNet.Run8.CustomInputClient.Tests.TestData
{
    public class ToggleMessageInvalidTypes : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                EMessageType.TrainBrake
            };
            yield return new object[]
            {
                EMessageType.DynamicBrakeLever
            };
            yield return new object[]
            {
                EMessageType.MuHeadlightSwitch
            };
            yield return new object[] {
                EMessageType.Wipers
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
