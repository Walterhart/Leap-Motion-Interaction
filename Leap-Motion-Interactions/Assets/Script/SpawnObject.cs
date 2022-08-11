using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject spawnObject;
    public int maxAmountOfObjects;
    public GameObject spawnerSetActive;
    public List<GameObject> objectList = new List<GameObject>();
    private float timeLeft, originalTime;
    // Update is called once per frame
    void Update()
    {
        
        timeLeft -= Time.deltaTime;
        
        if(timeLeft <= 0)
        {
           
            timeLeft = originalTime;
            Spawn();
        }
        spawnerSetActive.SetActive(false);



    }

    void Spawn()
    {
        if(objectList.Count < maxAmountOfObjects)
        {
            objectList.Add(Instantiate(spawnObject));
            Debug.Log("SpawnCount : " + objectList);
        }
        
    }

}
