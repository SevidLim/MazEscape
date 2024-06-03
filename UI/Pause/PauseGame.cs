using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject ESCPanel;
    public bool OnOff;

    private void OnDisable()
    {
        OnOff = false;
    }

    public void OpenPanel()
    {
        if (OnOff == false)
        {
            ESCPanel.SetActive(true);
            Time.timeScale = 0;
            OnOff = true;
        }
        else
        {
            ESCPanel.SetActive(false);
            Time.timeScale = 1;
            OnOff = false;
        }
    }
}
