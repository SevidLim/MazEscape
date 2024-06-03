using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string SceneName;

    public void OpenPenal()
    {
        //back to last scene
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previousScene" + SceneName, currentScene);
        
        SceneManager.LoadScene(SceneName);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1;
    }
}
