using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duplicate : MonoBehaviour
{
    public GameObject mummy;
    public static int count = 1;
    private IEnumerator coroutine;
    public GameObject sword;
    public GameObject flashlight;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        coroutine = DuplicateCoroutine();
        StartCoroutine(coroutine);
    }

    IEnumerator DuplicateCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        if(Duplicate.count <= 700){
            yield return new WaitForSeconds(10);
            Vector3 newPosition = new Vector3(transform.position.x + Random.Range(-1f, 1f), transform.position.y, transform.position.z + Random.Range(-2f, 2f));
            Quaternion randomRotation = Random.rotation;
            randomRotation.eulerAngles = new Vector3(0,Random.Range(0, 360f),0);
            Instantiate(mummy, newPosition, randomRotation);
            Duplicate.count++;
            Debug.Log(Duplicate.count);
            coroutine = DuplicateCoroutine();
            StartCoroutine(coroutine);
        }

        if(Duplicate.count == 1000){
           Destroy(this.gameObject);
        }
        
    }

    void OnMouseDown(){
        if(sword.GetComponent<SwordSwing>().isPickedUp){
            StopCoroutine(coroutine);
            Duplicate.count--;
            Debug.Log(Duplicate.count);

            if(Duplicate.count == 0){
                Instantiate(flashlight, transform.position, Random.rotation);
                Destroy(this.gameObject);
            }

            Destroy(this.gameObject);
        }
    }
}
