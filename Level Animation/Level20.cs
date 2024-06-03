using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level20 : MonoBehaviour
{
    public GameObject _canvas;
    public GameObject animCanvas;
    public GameObject _player;
    
    void Start()
    {
        _canvas.SetActive(true);
        animCanvas.SetActive(false);
        _player.SetActive(true);
    }
}
