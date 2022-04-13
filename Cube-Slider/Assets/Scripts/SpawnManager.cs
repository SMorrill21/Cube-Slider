using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;

    private GameManager gameManagerScript;
    private Vector3 spawnPos = new Vector3(0, 1, 70);
    private float spawnDelay = 1;
    private float spawnInterval = 2.75f;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("spawnObstacle", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnObstacle()
    {
        GameObject obstacle = obstaclePrefab[Random.Range(0, obstaclePrefab.Length)];

        if (!gameManagerScript.gameHasEnded)
        {
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
        }
    }
}
