using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMoveUI : MonoBehaviour
{
    public string moveUI;
    public Text _text;
    public GameObject _left;
    public GameObject _Right;

    void Start()
    {
        moveUI = PlayerPrefs.GetString("moveUI");
    
        if (moveUI == "")
        {
            moveUI = "Right";
        }
    }

    void Update()
    {
        _text.text = moveUI;

        if (moveUI == "Right")
        {
            _Right.SetActive(true);
            _left.SetActive(false);
        }
        else if (moveUI == "Left")
        {
            _Right.SetActive(false);
            _left.SetActive(true);
        }
    }

    public void OpenPanel()
    {
        if(moveUI == "Right")
        {
            moveUI = "Left";
        }
        else if(moveUI == "Left")
        {
            moveUI = "Right";
        }
        PlayerPrefs.SetString("moveUI", moveUI);
        PlayerPrefs.Save();
    }
}
