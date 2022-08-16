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

            if(timer < 0)
            {
                timer = timerReset;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            ControlReversalTrigger();
             
        }

        private void ControlReversalTrigger()
        {
            //When something collides with the orb, run this method
            //Check if a tank has collided with the orb
            //if()
            //If so, set the opposite tanks controls to inverse
            //Else nothing should happen
            //have it timed to revert back to normal controls after 3 seconds
            
        }
        

    }
}