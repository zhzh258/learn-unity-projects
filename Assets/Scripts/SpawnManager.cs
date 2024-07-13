using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPosition = new Vector3(30, 0, 0);
    public float startDelay = 2.0f;
    public float spawnDelay = 2.0f;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObject", startDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        if (playerControllerScript.gameOver == false)
        {
            print(spawnPosition.x);
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
