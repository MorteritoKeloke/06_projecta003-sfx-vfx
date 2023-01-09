using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private float startDelay = 2f;
    private float repeatRate = 2f;

    private void start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    } 
        private void SpawnObstacles()
    {
        Instantiate(obstaclePrefab, transform.position,
            obstaclePrefab.transform.rotation);
    }
}