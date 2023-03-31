using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duplicate : MonoBehaviour
{
    public GameObject mummy;
    public static int count = 3;
    private IEnumerator coroutine;
    public static GameObject sword;
    public static GameObject flashlight;
    public static AudioSource pickUpSound;
    public GameObject deathScreen;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        sword = GameObject.Find("sword");
        if(flashlight == null){
            flashlight = GameObject.Find("Flashlight");
        } else{
            flashlight.SetActive(false);
        }

        if(pickUpSound == null){
           GameObject w = GameObject.Find("PickUpSound");
           pickUpSound = w.GetComponent<AudioSource>();
        }

        coroutine = DuplicateCoroutine();
        StartCoroutine(coroutine);
        
    }

    IEnumerator DuplicateCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        if(Duplicate.count <= 700){
            yield return new WaitForSeconds(7);
            Vector3 newPosition = new Vector3(transform.position.x + Random.Range(-1f, 1f), transform.position.y, transform.position.z + Random.Range(-2f, 2f));
            Quaternion randomRotation = Random.rotation;
            randomRotation.eulerAngles = new Vector3(0,Random.Range(0, 360f),0);
            Instantiate(mummy, newPosition, randomRotation);
            Duplicate.count++;
            Debug.Log(Duplicate.count);
            coroutine = DuplicateCoroutine();
            StartCoroutine(coroutine);
        }

        if(Duplicate.count > 1000){
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            deathScreen.SetActive(true);
            Destroy(sword);
            Destroy(this.gameObject);
        }
        
    }

    void OnMouseDown(){
        if(sword && sword.GetComponent<SwordSwing>().isPickedUp){
            StopCoroutine(coroutine);
            Duplicate.count--;

            if(Duplicate.count == 0){
                flashlight.SetActive(true);
                this.gameObject.SetActive(false);
                if(pickUpSound != null){
                    pickUpSound.PlayOneShot(pickUpSound.clip, 1);
                }
            }

            Destroy(this.gameObject);
        }
    }
}
