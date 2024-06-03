using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 3.11)
        {
            SceneManager.LoadScene("Home");
        }

    }
}
