using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    public GameObject _Start;
    public GameObject _ChooseLevelPage;
    public GameObject _BackToStart;

    public void OpenPanel()
    {
        _Start.SetActive(false);
        _ChooseLevelPage.SetActive(true);
        _BackToStart.SetActive(true);
    }
}
