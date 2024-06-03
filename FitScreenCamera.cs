﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitScreenCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 0);
        Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(Vector3.zero) * 1;
        Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(mainCamera.rect.width, mainCamera.rect.height)) * 1;
        Vector3 screenSize = topRight - bottomLeft;
        float screenRatio = screenSize.x / screenSize.y;
        float desiredRatio = transform.localScale.x / transform.localScale.y;

        if (screenRatio > desiredRatio)
        {
            float height = screenSize.y;
            transform.localScale = new Vector3(height * desiredRatio, height);
        }
        else
        {
            float width = screenSize.x;
            transform.localScale = new Vector3(width, width / desiredRatio);
        }
    }
}
