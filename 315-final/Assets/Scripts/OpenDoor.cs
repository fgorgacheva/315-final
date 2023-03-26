using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject openDoor;
    public GameObject key;

    void OnMouseDown(){
        if(key.GetComponent<PickUp>().isPickedUp == true){
            this.gameObject.SetActive(false);
            openDoor.SetActive(true);
        };
    }

}
