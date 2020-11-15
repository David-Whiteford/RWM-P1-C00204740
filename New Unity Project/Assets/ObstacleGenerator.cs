using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            obstacle.SetActive(true);
        }
    }
}
