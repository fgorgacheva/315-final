using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{

    public string sceneNumber;
    
    void Update()
    {
            
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("LoadNextScene", 1f);
            Duplicate.count = 0;
        }
            

    }

    void LoadNextScene(){
        SceneManager.LoadScene("level-"+sceneNumber, LoadSceneMode.Single);
    }
}