using DispatcherDotNet.Run8.CustomInputClient.Run8;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace DispatcherDotNet.Run8.CustomInputClient
{
    /// <summary>
    /// Constant values used throught the code base.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Run8 toggle control off value.
        /// </summary>
        public const int OFF_VALUE = 0;

        /// <summary>
        /// Run8 toggle control on value;
        /// </summary>
        public const int ON_VALUE = 1;

        /// <summary>
        /// Run8 Non Audio message header.
        /// </summary>
        public const byte NON_AUDIO_HEADER = 96;

        /// <summary>
        /// Run8 Audio message header.
        /// </summary>
        public const byte AUDIO_HEADER = 224;

        /// <summary>
        /// Message types that are brake types.
        /// </summary>
        public static ImmutableList<EMessageType> BrakeMessageTypes = ImmutableList.Create(
            EMessageType.DynamicBrakeLever,
            EMessageType.IndependentBrakeLever,
            EMessageType.TrainBrake
        );

        /// <summary>
        /// Message types that are not a boolean or variable range.
        /// </summary>
        public static ImmutableList<EMessageType> MultiValueMessageTypes = ImmutableList.Create(
            EMessageType.DistanceCounter,
            EMessageType.HeadlightFront,
            EMessageType.HeadlightRear,
            EMessageType.MuHeadlightSwitch,
            EMessageType.IsolationSwitch,
            EMessageType.TractionMotors,
            EMessageType.Wipers,
            EMessageType.TrainBrakeCutOutValve,
            EMessageType.ServiceSelectorSwitch
        );
    }
}
