using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObject : MonoBehaviour
{

    private GameObject[] spawnedObject;
    public GameObject despawnerSetActive;
    
    // Update is called once per frame
    void Update()
    {
        DeSpawn();
        despawnerSetActive.SetActive(false);

    }
    private void DeSpawn()
    {
        
        spawnedObject = GameObject.FindGameObjectsWithTag("SpawnObject");
        if (spawnedObject != null)
        {

            for (int i = 0; i < spawnedObject.Length; i++)
            {

                Destroy(spawnedObject[i]);
                Debug.Log("Delete");
            }

           
        }
        else
            Debug.Log("Error: No object was dectected");

        

    }
}
