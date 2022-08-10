using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonControl : MonoBehaviour
{

    // top of button
    public Transform top;

    // upper and lower limit of button
    public Transform lowerLimit;
    public Transform upperLimitt;

    // variable for button trigger, value 0 or 1
    public float threshHold;

    //variable to help return  top to previous position
    public float force;

    private float distinct;
    public bool isPressed;
    private bool prevState;
    public AudioSource pressedSound;
    public AudioSource releasedSound;
    public UnityEvent onPressed;
    public UnityEvent onReleased;

    // Start is called before the first frame update
    void Start()
    {
        /* ignore collusion between top and base of button
        done by checking if base has angle of 0 */

        Physics.IgnoreCollision(GetComponent<Collider>(), top.GetComponent<Collider>());
        if (transform.eulerAngles != Vector3.zero)
        {
            Vector3 savedAngle = transform.eulerAngles;
            transform.eulerAngles = Vector3.zero;
            distinct = upperLimitt.position.y - lowerLimit.position.y;
            transform.eulerAngles = savedAngle;
        }
        else
            distinct = upperLimitt.position.y - lowerLimit.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // allows button to go only up and down 
        top.transform.localPosition = new Vector3(0, top.transform.localPosition.y, 0);
        top.transform.localEulerAngles = new Vector3(0, 0, 0);

        // transform position to upper limit
        if (top.localPosition.y >= 0)
            top.transform.position = new Vector3(upperLimitt.position.x, upperLimitt.position.y, upperLimitt.position.z);
        else
            top.GetComponent<Rigidbody>().AddForce(top.transform.up * force * Time.fixedDeltaTime);

        // transform position to lower limit
        if (top.localPosition.y <= lowerLimit.localPosition.y)
            top.transform.position = new Vector3(lowerLimit.position.x, lowerLimit.position.y, lowerLimit.position.z);

        //  Event
        if (Vector3.Distance(top.position, lowerLimit.position) < distinct * threshHold)
            isPressed = true;
        else
            isPressed = false;

        // Event handler
        if (isPressed && prevState != isPressed)
            Pressed();
        if (!isPressed && prevState != isPressed)
            Released();
    }


    // pressed button event handler
    void Pressed()
    {
        prevState = isPressed;
        pressedSound.pitch = 1;
        pressedSound.Play();
        onPressed.Invoke();
    }

    // realease button even handler
    void Released()
    {
        prevState = isPressed;
        releasedSound.pitch = Random.Range(1.1f, 1.2f);
        releasedSound.Play();
        onReleased.Invoke();
    }
}