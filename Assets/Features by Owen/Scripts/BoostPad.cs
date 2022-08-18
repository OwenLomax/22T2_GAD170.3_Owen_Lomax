using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{
    public class BoostPad : MonoBehaviour
    {
        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 2;

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
            if(other.gameObject.tag == "Tank")
            {
                BoostPadTrigger(other);
            }

            if(EventsByOwenLomax.OnBoostPadAction != null)
            {
                EventsByOwenLomax.OnBoostPadAction();
            }
        }

        private void BoostPadTrigger(Collider tank)
        {
            if (tank.gameObject.tag == "Tank")
            {
                tank.GetComponent<Tank>().tankMovement.speed = 24;
            }
        }   
    }
}