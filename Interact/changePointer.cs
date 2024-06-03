using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePointer : MonoBehaviour
{
    public GameObject _KeyArrow;
    public GameObject _FakeKeyeArrow;
    public GameObject _finalArrow;

    void OnTriggerEnter2D(Collider2D other)
    {
        _KeyArrow.SetActive(false);
        _FakeKeyeArrow.SetActive(false);
        _finalArrow.SetActive(true);
    }
}
