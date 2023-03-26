
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static void LoadNextScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
