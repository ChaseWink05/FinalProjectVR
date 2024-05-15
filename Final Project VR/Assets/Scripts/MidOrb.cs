using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidOrb : OVRGrabbable
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
            rb.velocity *= 2.5f;
            orbGrabbed = false;
        }


    }

}