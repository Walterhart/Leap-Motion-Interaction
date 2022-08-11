using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmssionControlOff : MonoBehaviour
{
    public Material material1, material2;
    public GameObject EmssionSetActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        material1.DisableKeyword("_EMISSION");
        material2.DisableKeyword("_EMISSION");
        EmssionSetActive.SetActive(false);
    }
}
