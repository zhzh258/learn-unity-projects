using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xSpawnRangeMin = -10;
    private float xSpawnRangeMax = 10;
    private float zSpawnRangeMin = 20;
    private float zSpawnRangeMax = 35;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}
    }

    void SpawnRandomAnimal()
    {
        // spawn a random animal
        int spawnIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(xSpawnRangeMin, xSpawnRangeMax), 0, UnityEngine.Random.Range(zSpawnRangeMin, zSpawnRangeMax));
        Quaternion spawnRotation = animalPrefabs[spawnIndex].transform.rotation;
        Instantiate(animalPrefabs[spawnIndex], spawnPosition, spawnRotation);
    }
}
