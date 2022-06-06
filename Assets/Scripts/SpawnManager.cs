using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), 2, 1.5f);
    }

    private void SpawnAnimal()
    {
        var animal = animals[Random.Range(0, animals.Length)];
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
