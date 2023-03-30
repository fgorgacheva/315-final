using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpTPItem : MonoBehaviour
{

    public AudioSource soundEffect;
    public GameObject loadScreen;
    public string level;

    // this method will load the next scene
    void LoadNextScene(){
        SceneManager.LoadScene("level-"+level, LoadSceneMode.Single);
    }

    //click sword to pick it up
    void OnMouseDown(){
        //show loading screen
        loadScreen.SetActive(true);
        
        //play teleporting out of scene sound
        soundEffect.PlayOneShot(soundEffect.clip, 1);        

        //sword disappears 
        this.gameObject.SetActive(false);

        //load next scene after sound is done playing
        Invoke("LoadNextScene", 5f);
    }
}
