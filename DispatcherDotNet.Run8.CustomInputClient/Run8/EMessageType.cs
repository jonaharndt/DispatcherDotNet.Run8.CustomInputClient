namespace DispatcherDotNet.Run8.CustomInputClient.Run8
{
    /// <summary>
    /// The various messages that can be sent to Run8.
    /// </summary>
    public enum EMessageType
    {
        /// <summary>
        /// Not yet used.
        /// </summary>
        Test = 0,

        /// <summary>
        /// Toggles the alerter.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Alerter = 1,

        /// <summary>
        /// Toggles the bell.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Bell = 2,

        /// <summary>
        /// Toggles the distance counter.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - Count Up
        /// 2 - Count Down
        /// </remarks>
        DistanceCounter = 3,

        /// <summary>
        /// Controls the dyanmic brakes.
        /// </summary>
        /// <remarks>
        /// 0-255. 0 is off. 255 is full dynamics.
        /// </remarks>
        DynamicBrakeLever = 4,

        /// <summary>
        /// Controls the front headlight.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - Dim
        /// 2 - Full
        /// </remarks>
        HeadlightFront = 5,

        /// <summary>
        /// Controls the rear headlight.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - Dim
        /// 2 - Full
        /// </remarks>
        HeadlightRear = 6,

        /// <summary>
        /// Toggles the MU headlight mode.
        /// </summary>
        /// <remarks>
        /// 0 - SingleMiddle
        /// 1 - ShortHoodLead
        /// 2 - ShortHoodTrail
        /// 3 - LongHoodLead
        /// 4 - LongHoodTrail
        /// </remarks>
        MuHeadlightSwitch = 7,

        /// <summary>
        /// Toggles the horn.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Horn = 8,

        /// <summary>
        /// Controls the independent brakes.
        /// </summary>
        /// <remarks>
        /// 0-255. 0 is off. 255 is full application.
        /// </remarks>
        IndependentBrakeLever = 9,

        /// <summary>
        /// Bails off the independent brake.
        /// </summary>
        /// <remarks>
        /// 0 - Release
        /// 1 - Bail Off
        /// </remarks>
        IndependentBrakeBailOff = 10,

        /// <summary>
        /// Controls the isolation switch.
        /// </summary>
        /// <remarks>
        /// 0 - Start
        /// 1 - Isolate
        /// 2 - Run
        /// </remarks>
        IsolationSwitch = 11,

        /// <summary>
        /// Sets the parking brake.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        ParkingBrakeOn = 12,

        /// <summary>
        /// Sets the parking brake.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        ParkingBrakeOff = 13,

        /// <summary>
        /// Sets the reverser position.
        /// </summary>
        /// <remarks>
        /// 0 - Reverse
        /// 1 to 254 - Neutral
        /// 255 - Forward
        /// </remarks>
        Reverser = 14,

        /// <summary>
        /// Toggles the sander.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Sander = 15,

        /// <summary>
        /// Sets the throttle position.
        /// </summary>
        /// <remarks>
        /// 0 - 8 corresponds to each notch.
        /// </remarks>
        Throttle = 16,

        /// <summary>
        /// Controls the traction motors.
        /// </summary>
        /// <remarks>
        /// Flag bit 8 and set bits 1 - 6 for each traction motor (0 off, 1 on)
        /// </remarks>
        TractionMotors = 17,

        /// <summary>
        /// Controls the train brake.
        /// </summary>
        /// <remarks>
        /// 0-255. 0 is off. 255 is emergency.
        /// </remarks>
        TrainBrake = 18,

        /// <summary>
        /// Controls the wipers.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - Intermediate 1
        /// 2 - Intermediate 2
        /// 3 - Full
        /// </remarks>
        Wipers = 19,

        /// <summary>
        /// Sends DTMF Tone 0.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf0 = 20,

        /// <summary>
        /// Sends DTMF Tone 1.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf1 = 21,

        /// <summary>
        /// Sends DTMF Tone 2.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf2 = 22,

        /// <summary>
        /// Sends DTMF Tone 3.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf3 = 23,

        /// <summary>
        /// Sends DTMF Tone 4.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf4 = 24,

        /// <summary>
        /// Sends DTMF Tone 5.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf5 = 25,

        /// <summary>
        /// Sends DTMF Tone 6.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf6 = 26,

        /// <summary>
        /// Sends DTMF Tone 7.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf7 = 27,

        /// <summary>
        /// Sends DTMF Tone 8.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf8 = 28,

        /// <summary>
        /// Sends DTMF Tone 9.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        Dtmf9 = 29,

        /// <summary>
        /// Sends DTMF Tone #.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        DtmfPound = 30,

        /// <summary>
        /// Sends DTMF Tone *.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        DtmfStar = 31,

        /// <summary>
        /// Increases the radio volume.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        RadioVolumeUp = 32,

        /// <summary>
        /// Decreases the radio volume.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        RadioVolumeDown = 33,

        /// <summary>
        /// Mutes the radio.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        RadioMute = 34,

        /// <summary>
        /// Sets the radio to channel mode.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        RadioChannelMode = 35,

        /// <summary>
        /// Sets the radio to DTMF mode.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        RadioDtmfMode = 36,

        /// <summary>
        /// Toggles the control circut breaker.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        CircutBreakerControl = 37,

        /// <summary>
        /// Toggles the dynamic brake circut breaker.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        CircutBreakerDynamicBrake = 38,

        /// <summary>
        /// Toggles the engine run circut breaker.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        CircutBreakerEngineRun = 39,

        /// <summary>
        /// Toggles the generator field circut breaker.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        CircutBreakerGeneratorField = 40,

        /// <summary>
        /// Toggles the cab lights.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        CabLights = 41,

        /// <summary>
        /// Toggles the step lights.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        StepLights = 42,

        /// <summary>
        /// Toggles the gauge lights.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        GaugeLights = 43,

        /// <summary>
        /// Toggles EOT Emergency Stop.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        EotEmergencyStop = 44,

        /// <summary>
        /// Auto Start train.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        AutoStartTrain = 45,

        /// <summary>
        /// Auto MU train.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        AutoMuTrain = 46,

        /// <summary>
        /// Auto Circut Breaker train.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        AutoCbTrain = 47,

        /// <summary>
        /// Auto Air Break train.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        AutoAbTrain = 48,

        /// <summary>
        /// Auto EOT train.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        AutoEotTrain = 49,

        /// <summary>
        /// Starts the engine.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        EngineStart = 50,

        /// <summary>
        /// Stops the engine.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        EngineStop = 51,

        /// <summary>
        /// Toggles HEP.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        HeadEndPower = 52,

        /// <summary>
        /// Cuts out the train brakes.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        TrainBrakeCutOutValve = 53,

        /// <summary>
        /// Toggles the service selector switch.
        /// </summary>
        /// <remarks>
        /// 0 - Switch1
        /// 1 - Switch2
        /// 2 - Forestalling
        /// 3 - Road
        /// </remarks>
        ServiceSelectorSwitch = 54,

        /// <summary>
        /// Toggles slow speed control.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        SlowSpeedToggle = 55,

        /// <summary>
        /// Increments the slow speed setting.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        SlowSpeedIncrement = 56,

        /// <summary>
        /// Decrements the slow speed setting.
        /// </summary>
        /// <remarks>
        /// 0 - Off
        /// 1 - On
        /// </remarks>
        SlowSpeedDecrement = 57
    }
}