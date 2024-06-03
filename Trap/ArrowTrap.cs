using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ArrowTrap : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject arrow;
    float timebetween;
    public float startTimeBetween;
    public bool no2shoot;

    void Start()
    {
        timebetween = startTimeBetween;

        if (no2shoot)
        {
            timebetween = startTimeBetween/2;
        }
    }

    void Update()
    {
        if (timebetween <= 0)
        {
            Instantiate(arrow, shootPoint.position, transform.rotation);
            timebetween = startTimeBetween;
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    } 
}