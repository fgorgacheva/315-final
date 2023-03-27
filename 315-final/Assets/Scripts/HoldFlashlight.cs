using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldFlashlight : MonoBehaviour
{
    public Transform parent;
    public bool isPickedUp = true;

    // Start is called before the first frame update
    void Start()
    {
        // this.transform.SetParent(parent); 
        this.transform.localPosition = new Vector3(0.46f,0.25f,0.45f);
        this.transform.localEulerAngles = new Vector3(7.014f, 93.767f, 101.436f);
    }

}
