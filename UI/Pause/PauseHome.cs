using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHome : MonoBehaviour
{    
    public GameObject _TutorialButton;
    public GameObject _PauseButton;
    public GameObject _Pause;
    public GameObject _Maze;
    public GameObject _Start;

    public void OpenPanel()
    {
        Time.timeScale = 1;
        _TutorialButton.SetActive(true);
        _PauseButton.SetActive(true);
        _Pause.SetActive(false);
        _Maze.SetActive(false);
        _Start.SetActive(true);
    }
}
