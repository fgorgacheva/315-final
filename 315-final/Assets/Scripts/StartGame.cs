using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static void LoadNextScene(string sceneName){
        Debug.Log("loading screen");
        SceneManager.LoadScene(sceneName);
    }
}