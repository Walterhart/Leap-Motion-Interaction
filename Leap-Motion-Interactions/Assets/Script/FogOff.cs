using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOff : MonoBehaviour
{
    public GameObject fogSetActive;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        RenderSettings.fog = false;
        fogSetActive.SetActive(false);
    }
}
