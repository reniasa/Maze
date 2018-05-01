using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets.Scripts
{

    public class FollowingCamera : MonoBehaviour
    {

        public GameObject player;       
        private Vector3 offset;         

        void Start()
        {
            offset = new Vector3(2, 2.5f, -2);
                
        }

        void LateUpdate()
        {
            transform.position = player.transform.position;
        }
    }
}
