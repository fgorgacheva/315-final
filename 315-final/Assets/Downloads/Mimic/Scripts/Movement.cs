using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MimicSpace
{
    /// <summary>
    /// This is a very basic movement script, if you want to replace it
    /// Just don't forget to update the Mimic's velocity vector with a Vector3(x, 0, z)
    /// </summary>


    public class Movement : MonoBehaviour
    {
        [Header("Controls")]
        [Tooltip("Body Height from ground")]
        [Range(0.5f, 5f)]
        public float speed = 0.5f;
        Mimic myMimic;
        private bool isMoving = true;


        public Transform player;


        private void Start()
        {
            myMimic = GetComponent<Mimic>();
        }

        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            myMimic.velocity = player.position - transform.position;
        }


    }

}