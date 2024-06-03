using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelText : MonoBehaviour
{
    [SerializeField] int currentSceneIndex;
    public Text _text;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        currentSceneIndex -= 2;
        currentSceneIndex.ToString();
        
        _text.text = ("Level " + currentSceneIndex.ToString());
    }
}
