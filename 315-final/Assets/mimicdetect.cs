using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimicdetect : MonoBehaviour
{
    public GameObject mimic;

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<BoxCollider>().bounds.Contains(mimic.transform.position))
        {
            Debug.Log("HI");    
        }
    }
}
