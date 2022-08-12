using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmssionControlOff : MonoBehaviour
{
    public Material material1, material2;
    public GameObject EmssionSetActive;

    private void Start()
    {
        material1.DisableKeyword("_EMISSION");
        material2.DisableKeyword("_EMISSION");
    }
    // Update is called once per frame
    void Update()
    {
        material1.DisableKeyword("_EMISSION");
        material2.DisableKeyword("_EMISSION");
        EmssionSetActive.SetActive(false);
    }
}
