using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private Vector3 spawnPos;
    private int spawnBound = 4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFood", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFood()
    {
        int index = Random.Range(0, foodPrefabs.Length);
        int spawnPosX = Random.Range(-spawnBound, spawnBound);
        spawnPos = new Vector3(spawnPosX, 1, -70);
        //waitingTime = Random.Range(2, 5);
        Instantiate(foodPrefabs[index], spawnPos, foodPrefabs[index].transform.rotation);
        
    }
}
