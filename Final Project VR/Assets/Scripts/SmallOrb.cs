using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallOrb : OVRGrabbable
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
            rb.velocity *= 3;
            orbGrabbed = false;
        }


    }

}