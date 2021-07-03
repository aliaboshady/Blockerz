using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    SpawnPoint[] spawnPoints;

    void Awake()
    {
        spawnPoints = FindObjectsOfType<SpawnPoint>();
        int randInx = Random.Range(0, spawnPoints.Length);
        transform.position = spawnPoints[randInx].transform.position;
    }
}
