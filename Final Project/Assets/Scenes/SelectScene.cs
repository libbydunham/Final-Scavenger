using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void Select(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
