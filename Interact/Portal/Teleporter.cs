using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject _button;

    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _button.SetActive(false);
    }
}
