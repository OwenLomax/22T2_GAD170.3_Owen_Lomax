using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{
    public class EventsByOwenLomax : MonoBehaviour
    {
        public delegate void ControlReversalOrbAction();
        public static ControlReversalOrbAction OnControlReversalOrbAction;

        public delegate void BoostPadAction();
        public static BoostPadAction OnBoostPadAction;

        public delegate void TeleporterAction();
        public static TeleporterAction OnTeleporterAction;
    }
}