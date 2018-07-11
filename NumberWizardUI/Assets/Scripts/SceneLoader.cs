using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        sceneIndex = sceneIndex == SceneManager.sceneCountInBuildSettings - 1 ? -1 : sceneIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
