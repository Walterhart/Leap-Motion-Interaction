using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionControl : MonoBehaviour
{
    public Material material1, material2, material3;
    public GameObject EmssionSetActive;
    // Start is called before the first frame update
    void Start()
    {
        material1.DisableKeyword("_EMISSION");
        material2.DisableKeyword("_EMISSION");
        material1.DisableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        material1.EnableKeyword ("_EMISSION");
        material2.EnableKeyword("_EMISSION");
        material3.EnableKeyword("_EMISSION");
        EmssionSetActive.SetActive(false);
    }
}
