using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickContinue : MonoBehaviour
{

    public GameObject blackScreen;
    public GameObject message;
    private int clickCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        blackScreen.active = true;
        message.active = true;
    }

    void Update()
    {
        
       if (Input.GetMouseButtonDown(0))
       {
            clickCount++;
            switch(clickCount) 
            {
                case 1:
                    this.gameObject.active = false;
                    blackScreen.active = false;
                    message.active = false;
                    break;
            }
       }
    }

}
