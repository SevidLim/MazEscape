using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousScene : MonoBehaviour
{
    int sceneIndex;
    int SceneToOpen;
        
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (!PlayerPrefs.HasKey("previousScene" + sceneIndex))
        {
            PlayerPrefs.SetInt("previousScene" + sceneIndex, sceneIndex);
        }

        SceneToOpen = PlayerPrefs.GetInt("previousScene" + sceneIndex);
    }

    public void OpenPanel()
    {
        SceneManager.LoadScene(SceneToOpen);
    }
}
