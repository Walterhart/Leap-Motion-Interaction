using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaySound : MonoBehaviour
{

    public AudioSource pressedSound;
    public AudioSource releasedSound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Pressed();

    }


    // pressed button event handler
    void Pressed()
    {
        pressedSound.pitch = 1;
        pressedSound.Play();
    }
}
   