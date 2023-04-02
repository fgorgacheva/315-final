using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public GameObject deathScreen;

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowDeathScreen(){
        deathScreen.active = true;
        
    }
}
