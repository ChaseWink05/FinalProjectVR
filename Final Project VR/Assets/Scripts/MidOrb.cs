using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Same Exact logic as the smallorb script and the largeorb script besides for one small change

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
            rb.velocity *= 2.5f; //This is the only difference in the scripts. I am making the velocity smaller so it is harder to throw across the other side since it is a bigger sized orb
            orbGrabbed = false;
        }


    }

}