using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    private void OnDisable()
    {
        transform.position = originalPos;
    }
}
