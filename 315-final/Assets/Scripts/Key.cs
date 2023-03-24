using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public float spinSpeed;
    public GameObject door;
    public GameObject particles;
    public AudioSource soundEffect;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f ,spinSpeed * Time.deltaTime, Space.Self);
    }

    void OnMouseDown(){
        Destroy (this.gameObject);
        Destroy (door);

        particles.SetActive(true);
        // soundEffect.SetActive(true);
        soundEffect.PlayOneShot(soundEffect.clip, 1);
    }
}
