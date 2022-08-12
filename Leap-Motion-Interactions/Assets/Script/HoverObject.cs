using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverObject : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float equilibrium;

    public Vector3 tempPosition;
    // Start is called before the first frame update
    void Start()
    {

        tempPosition = transform.position;
    }


    void FixedUpdate()
    {
        // positive move right negative to left
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * equilibrium;
        transform.position = tempPosition;

    }
}
