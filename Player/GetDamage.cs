using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public GameObject _gameOver;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Damage")
        {
            _gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
}
