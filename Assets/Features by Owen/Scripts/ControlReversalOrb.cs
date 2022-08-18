using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{
    public class ControlReversalOrb : MonoBehaviour
    {
        [SerializeField] private GameObject controlOrbSpawnPoint;
        [SerializeField] private GameObject controlOrbPrefab;

        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 3;

        private void Start()
        {
            timer = timerReset;
        }

        private void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = timerReset;


            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Tank")
            {
                ControlReversalTrigger(other);
            }

            if (EventsByOwenLomax.OnControlReversalOrbAction != null)
            {
                EventsByOwenLomax.OnControlReversalOrbAction();
            }
        }

        private void ControlReversalTrigger(Collider tank)
        {
            tank.GetComponent<Tank>().tankControls.forward = KeyCode.S;
            tank.GetComponent<Tank>().tankControls.backwards = KeyCode.W;
            tank.GetComponent<Tank>().tankControls.left = KeyCode.D;
            tank.GetComponent<Tank>().tankControls.right = KeyCode.A;
        }
    }
}