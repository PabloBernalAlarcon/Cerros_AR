using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicSpawner : MonoBehaviour
{
    public GameObject Sonic;
    public float SpawnRate; // = 3 seconds

    float timer = 0;
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            Instantiate(Sonic,null);
            timer = 0;
        }
    }
}
