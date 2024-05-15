using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBallon : MonoBehaviour
{
    private Rigidbody r;
    private OVRGrabbable GrabScript;
    private bool balloonGrabbed;
    
    private void Start()
    {
        GrabScript = GetComponent<OVRGrabbable>();
        r = GetComponent<Rigidbody>();

    }
   
    // Update is called once per frame
    void Update()
    {
        if (GrabScript.isGrabbed)
        {
            balloonGrabbed = true;
        } else if (balloonGrabbed)
        {
            r.useGravity = false;
            r.AddForce(new Vector3(0, 30, 0));
            balloonGrabbed = false;
        }




        /*if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            r = GetComponent<Rigidbody>();
            r.useGravity = false;
            r.AddForce(new Vector3(0, 30, 0));
            
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            r = GetComponent<Rigidbody>();
            r.velocity = new Vector3(0, 1, 0);
        } */
    } 
}
