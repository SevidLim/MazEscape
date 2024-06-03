using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratNext : MonoBehaviour
{
    [SerializeField] int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void OpenPanel()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
