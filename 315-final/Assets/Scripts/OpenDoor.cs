using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject openDoor;
    public GameObject key;
    public AudioSource openDoorSound;
    public AudioSource lockedDoorSound;

    void OnMouseDown(){
        if(key.GetComponent<PickUp>().isPickedUp == true){
            openDoorSound.PlayOneShot(openDoorSound.clip, 1);
            openDoor.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else{
            lockedDoorSound.PlayOneShot(lockedDoorSound.clip, 1);
        }
    }

}
