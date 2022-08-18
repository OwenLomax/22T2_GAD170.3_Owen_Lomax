using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{
    public class Teleporter : MonoBehaviour
    {
        [SerializeField] private GameObject teleporterPrefab;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Tank")
            {
                TeleporterTrigger(other);
            }

            if(EventsByOwenLomax.OnTeleporterAction != null)
            {
                EventsByOwenLomax.OnTeleporterAction();
            }
        }

        private void TeleporterTrigger(Collider tank)
        {
            tank.GetComponent<Tank>().transform.position = new Vector3(-32, 0, 33);

        }
    }
}