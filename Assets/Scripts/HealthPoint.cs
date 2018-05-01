using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class HealthPoint : MonoBehaviour
    {
        AbstractFactory healthCubeFactory = new HealthCube();
        AbstractFactory healthSphereFactory = new HealthSphere();

        public GameObject player;
        public GameObject FirstTransformPoint;
        public GameObject SecondTransformPoint;

        void Start()
        {
            healthCubeFactory.CreateHealthObject();
            healthSphereFactory.CreateHealthObject();
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Player")
            {
                MoveTo();
                if (gameObject.transform.tag == "HealthSphere")
                {
                    player.GetComponent<PlayerHealth>().HealthPoints += healthSphereFactory.RegenerateHealthpoints;
                }
                else
                {
                    player.GetComponent<PlayerHealth>().HealthPoints += healthCubeFactory.RegenerateHealthpoints;
                }
            }
        }

        private void MoveTo()
        {
            if(gameObject.transform.position == FirstTransformPoint.transform.position)
            {
                gameObject.transform.position = SecondTransformPoint.transform.position;
            }   
            else
            {
                gameObject.transform.position = FirstTransformPoint.transform.position;
            }
        }
    }
}
