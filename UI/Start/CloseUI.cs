using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public GameObject _UI;

    public void OpenPanel()
    {
        _UI.SetActive(false);
    }
}
