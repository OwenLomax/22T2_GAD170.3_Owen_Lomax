using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace OwenLomax
{
    public class GameStatisticsScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] gameStatisticsUIElements = new TextMeshProUGUI[3];

        [SerializeField] private TextMeshProUGUI ControlReversalOrbCounter;
        [SerializeField] private int controlReverseCount = 0;

        [SerializeField] private TextMeshProUGUI BoostPadUseCounter;
        [SerializeField] private int BoostPadUseCount = 0;

        [SerializeField] private TextMeshProUGUI TeleporterUseCounter;
        [SerializeField] private int TeleporterUseCount = 0;

        private void OnEnable()
        {
            EventsByOwenLomax.OnControlReversalOrbAction += IncreaseControlReversalOrbCount;
            EventsByOwenLomax.OnBoostPadAction += IncreaseBoostPadUseCount;
            EventsByOwenLomax.OnTeleporterAction += IncreaseTeleporterUseCount;
        }

        private void OnDisable()
        {
            EventsByOwenLomax.OnControlReversalOrbAction -= IncreaseControlReversalOrbCount;
            EventsByOwenLomax.OnBoostPadAction -= IncreaseBoostPadUseCount;
            EventsByOwenLomax.OnTeleporterAction -= IncreaseTeleporterUseCount;
        }

        private void IncreaseControlReversalOrbCount()
        {
            controlReverseCount++;
            ControlReversalOrbCounter.text = "Orbs Collected: " + controlReverseCount;
        }

        private void IncreaseBoostPadUseCount()
        {
            BoostPadUseCount++;
            BoostPadUseCounter.text = "Boost Pad Count: " + BoostPadUseCount;
        }

        private void IncreaseTeleporterUseCount()
        {
            TeleporterUseCount++;
            TeleporterUseCounter.text = "Teleporters used: " + TeleporterUseCount;
        }
    }
}