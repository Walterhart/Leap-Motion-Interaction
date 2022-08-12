using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOn : MonoBehaviour
{
    public GameObject fogSetActive;
    // Start is called beore the first frame update
    void Start()
    {
        RenderSettings.fog = false;
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.fog = true;
        fogSetActive.SetActive(false);
    }
}
