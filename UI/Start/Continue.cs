using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject _Start;
    public GameObject _InGameLevel;
    public GameObject _TutorialButton;
    public GameObject _PauseButton;
    public GameObject[] _Maze;


    public void OpenPanel()
    {
        Time.timeScale = 1;
        _Start.SetActive(false);
        _InGameLevel.SetActive(true);
        _Maze[0].SetActive(true);
        deactivateall();
        _TutorialButton.SetActive(true);
        _PauseButton.SetActive(true);
    }

    public void deactivateall()
    {
        _Maze[1].SetActive(false);
        _Maze[2].SetActive(false);
    }
}
