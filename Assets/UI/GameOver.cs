using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void CurrentPlays(int total)
    {
        GetComponent<Text>().enabled = total < 0;
    }

    private void Update()
    {
        if (GetComponent<Text>().enabled && Input.anyKeyDown) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
