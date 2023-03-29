using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{

    public AudioSource pickUpSound;
    public AudioSource teleportSound;
    public GameObject loadScreen;
    public bool isPickedUp = false;
    public string sceneName;

    void LoadNextScene(){
        if(sceneName != ""){
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        
    }

    void OnMouseDown(){
        isPickedUp = true;

        //if scene name NOT specified, play regular pick up behaviour
        if(sceneName == ""){
            pickUpSound.PlayOneShot(pickUpSound.clip, 1);
            this.gameObject.SetActive(false);
        }

        //if scene name is specified, play scene change behaviour
        if(sceneName != ""){
            loadScreen.SetActive(true);
            this.gameObject.SetActive(false);
            teleportSound.PlayOneShot(teleportSound.clip, 1);
            Invoke("LoadNextScene", 5f);
        }
    }

}
