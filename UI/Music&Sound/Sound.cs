using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource soundPlayer;

    public void playSound()
    {
        soundPlayer.Play();
    }
}
