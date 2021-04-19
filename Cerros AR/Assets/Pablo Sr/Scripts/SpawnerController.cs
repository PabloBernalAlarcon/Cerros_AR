using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject itemToSpawn;
    public float SpawnTime;
    float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= SpawnTime)
        {
            elapsedTime = 0;
            Instantiate(itemToSpawn, null);
        }
    }
}
