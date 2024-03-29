using DispatcherDotNet.Run8.CustomInputClient.Run8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatcherDotNet.Run8.CustomInputClient.Tests.TestData
{
    public class BrakeMessageInvalidTypes : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                EMessageType.Alerter
            };
            yield return new object[]
            {
                EMessageType.HeadEndPower
            };
            yield return new object[]
            {
                EMessageType.Horn
            };
            yield return new object[] {
                EMessageType.HeadlightFront
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
