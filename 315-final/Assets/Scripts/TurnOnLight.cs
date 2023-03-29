using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLight : MonoBehaviour
{
    public AudioSource click;
    public AudioSource deathSound;
    public Material buttonClicked;
    public GameObject directionalLight;
    public GameObject monster;
    public GameObject particles;


    // Update is called once per frame
    void OnMouseDown()
    {
        directionalLight.SetActive(true);
        this.gameObject.GetComponent<MeshRenderer> ().material = buttonClicked;
        click.PlayOneShot(click.clip, 1);

        MonsterDeath();
    }


    void MonsterDeath(){
        deathSound.PlayOneShot(deathSound.clip, 1);
        monster.SetActive(false); 
        // particles.position = monster.position;
        particles.SetActive(true);
    }
    //kill the monster slowly as it screenches
    //particles on kill
    //on kill drop carrot and knife

}
