using DispatcherDotNet.Run8.CustomInputClient.Run8;
using System.Collections;

namespace DispatcherDotNet.Run8.CustomInputClient.Tests.TestData
{
    public class CrcTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                EMessageType.Alerter,
                1,
                96
            };
            yield return new object[]
            {
                EMessageType.Horn,
                1,
                105
            };
            yield return new object[]
            {
                EMessageType.IndependentBrakeLever,
                255,
                150
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
