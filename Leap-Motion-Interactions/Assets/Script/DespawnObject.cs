using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObject : MonoBehaviour
{

    private GameObject[] spawnedObject;
    public GameObject despawnerSetActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                Destroy(spawnedObject[i].gameObject);
            }

           
        }
        else
            Debug.Log("Error: No object was dectected");

        

    }
}
