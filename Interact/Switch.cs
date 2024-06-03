using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    [Header("show button")]
    public GameObject _Button;

    [Header("change text")]
    public Text SwitchText;

    [Header("switch Image")]
    public GameObject _open;
    public GameObject _close;

    [Header("Door Image")]
    public GameObject _Door;
    public GameObject _DoorOpen;
    public GameObject _Door2;
    public GameObject _DoorOpen2;

    public bool OnOff;

    void Start()
    {
        OnOff = false;
    }

    public void OpenPanel()
    {
        if (OnOff == false)
        {
            SwitchText.text = "On";
            _open.SetActive(true);
            _close.SetActive(false);
            _Door.SetActive(false);
            _DoorOpen.SetActive(true);
            _Door2.SetActive(false);
            _DoorOpen2.SetActive(true);
            OnOff = true;
        }
        else
        {
            SwitchText.text = "Off";
            _open.SetActive(false);
            _close.SetActive(true);
            _Door.SetActive(true);
            _DoorOpen.SetActive(false);
            _Door2.SetActive(true);
            _DoorOpen2.SetActive(false);
            OnOff = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _Button.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _Button.SetActive(false);
    }
}
