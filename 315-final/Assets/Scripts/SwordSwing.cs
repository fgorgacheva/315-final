using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public Transform parent;
    public bool isPickedUp = true;
    private Animator anim;

    // public float localPositionX = 0.4f;
    // public float localEulerAnglesY = 90;
    // public float localEulerAnglesZ = 45;


    void Start(){
        this.anim = gameObject.GetComponent<Animator>();

        this.transform.SetParent(parent);
        this.isPickedUp = true;
        
        this.transform.localPosition = new Vector3(0.46f,0.25f,0.45f);
        this.transform.localEulerAngles = new Vector3(0, 90, 45);
    }
    
    // Update is called once per frame
    void Update()
    {
        
       if (Input.GetMouseButtonDown(0) && isPickedUp)
       {
            anim.enabled = true;
            this.anim.Play("swing");
       }
    }

    void OnMouseDown(){

        isPickedUp = true;       
        
        
        
    }
}
