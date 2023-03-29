using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject openDoor;
    public GameObject key;
    public AudioSource openDoorSound;

    void OnMouseDown(){
        if(key.GetComponent<PickUp>().isPickedUp == true){
            openDoorSound.PlayOneShot(openDoorSound.clip, 1);
            openDoor.SetActive(true);
            this.gameObject.SetActive(false);
        };
    }

}
