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
            yield return new WaitForSeconds(6);
            Vector3 newPosition = new Vector3(transform.position.x + Random.Range(-2f, 2f), transform.position.y, transform.position.z + Random.Range(-2f, 2f));
            Instantiate(mummy, newPosition, transform.rotation);
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

            if(Duplicate.count == 0){
                Destroy(this.gameObject);
            }

            Destroy(this);
        }
    }
}