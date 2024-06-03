using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PauseUI;
    public GameObject SettingPanel;
    public GameObject Congrat;
    public GameObject GameOver;

    void Start()
    {
        PauseUI.SetActive(false);
        SettingPanel.SetActive(false);
        Congrat.SetActive(false);
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
