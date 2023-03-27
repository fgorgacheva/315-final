using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    public float spinSpeed;
    public string axis;

    // Update is called once per frame
    void Update()
    {
        switch (axis){
            case "x":
            transform.Rotate(spinSpeed * Time.deltaTime, 0f ,0f, Space.Self);
            break;
            
            case "y":
            transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.Self);
            break;

            case "z":
            transform.Rotate(0f, 0f, spinSpeed * Time.deltaTime, Space.Self);
            break;
        }
        
    }

}
