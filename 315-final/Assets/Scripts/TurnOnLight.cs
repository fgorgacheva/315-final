using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MimicSpace;

public class TurnOnLight : MonoBehaviour
{
    public AudioSource click;
    public AudioSource deathSound;
    // public Material buttonClicked;
    public GameObject switchOn;
    public GameObject directionalLight;
    public GameObject mimic;
    public GameObject particles;


    // Update is called once per frame
    void OnMouseDown()
    {
        directionalLight.SetActive(true);
        switchOn.SetActive(true);
        // this.gameObject.GetComponent<MeshRenderer>().material = buttonClicked;
        click.PlayOneShot(click.clip, 1);
        Invoke("MonsterDeath", 2f);
        this.gameObject.SetActive(false);
    }


    void MonsterDeath(){
        deathSound.PlayOneShot(deathSound.clip, 1);
        mimic.SetActive(false); 
        particles.transform.position = mimic.transform.position;
        particles.SetActive(true);
    }
    //kill the monster slowly as it screenches
    //particles on kill
    //on kill drop carrot and knife

}
