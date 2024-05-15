using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallOrb : OVRGrabbable
{
    private Rigidbody rb; //Rigid body variable so we can control it later on

    private OVRGrabbable GrabScript; //Actually getting the OVRGrabble script from the other scripts so we can use it here
    private bool orbGrabbed; //Making a bool so that way we can keep track if the orb is grabbed or not later on in the script


    //public TextManager textManager;
    //public ScoreManager scoreManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GrabScript = GetComponent<OVRGrabbable>();

    }
    void Update()
    {
        //Here I am using some logic I had from the latern assignemnet we had to do ealier in the year. Bascially I am saying if the object is being grab then it will do something
        if (GrabScript.isGrabbed)
        {
            orbGrabbed = true; //Setting a variable to true if the orb is grabbed
        }
        else if (orbGrabbed) //so if that bool is true then we make the velocity of the rigidbody higher so its easier to throw
        {
            rb.velocity *= 3;
            orbGrabbed = false; //Then we are turning off the bool so that it doesn't continusly go on every frame since it is in the update function
        }


    }

}