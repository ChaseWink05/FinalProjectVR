using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Again this is the same logic as the MidOrb and the Small orb but with one difference the velocity

public class LargeOrb : OVRGrabbable
{
    private Rigidbody rb;

    private OVRGrabbable GrabScript;
    private bool orbGrabbed;


    //public TextManager textManager;
    //public ScoreManager scoreManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GrabScript = GetComponent<OVRGrabbable>();

    }
    void Update()
    {
        if (GrabScript.isGrabbed)
        {
            orbGrabbed = true;
        }
        else if (orbGrabbed)
        {
            rb.velocity *= 2; //Making this smaller again because it is a bigger sized orb so it must be harder to throw as it would be in real life
            orbGrabbed = false;
        }


    }

}