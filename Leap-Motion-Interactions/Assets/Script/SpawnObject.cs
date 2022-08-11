using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject spawnObject;
    public int spawnCount = 0;
    public bool spawning = false;

    // Update is called once per frame
    void Update()
    {
        
            if (spawnCount <= 3)
            {
                Spawn(spawnCount);
                spawnCount += 1;
            }
        
    }

    void Spawn(int spawnCount)
    {
        Instantiate(spawnObject);   
    }

}
