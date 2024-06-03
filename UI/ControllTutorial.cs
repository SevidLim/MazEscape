using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllTutorial : MonoBehaviour
{
    public GameObject ShowImage;

    public void OpenPanel() 
    {
        if(ShowImage != null)
        {
            bool isActive = ShowImage.activeSelf;

            ShowImage.SetActive(!isActive);
        }
    }
}
