using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoReset : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        Panel.SetActive(false);
    }
}
