using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject _Key;
    public GameObject _finalLock;
    public GameObject _final;

    void OnTriggerEnter2D(Collider2D other)
    {
        _Key.SetActive(false);
        _finalLock.SetActive(false);
        _final.SetActive(true);
    }
}