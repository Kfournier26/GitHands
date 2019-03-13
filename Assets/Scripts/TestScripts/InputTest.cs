using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class InputTest : MonoBehaviour
{

    public OVRInput.Controller Controller;

    // Use this for initialization
    void Start()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }

    // Update is called once per frame
    void Update()
    {
       // transform.localPosition = OVRInput.GetLocalControllerPosition(Controller);
       // transform.localPosition = OVRInput.GetLocalControllerPosition(Controller);

        if (OVRInput.Get(OVRInput.Button.One))
            //if (Input.GetKey("0"))
            {
                Debug.Log("TESTING");
                // OVRDebugInfo.print("Hellowworld");
            }

        //   if (Input.GetButtonDown("Oculus_GearVR_LIndexTrigger"))
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
                Debug.Log("WEEEEEEEE");
            }

        //Debug.Log("Wee");

        if (Input.anyKey)
        {
            Debug.Log("Whatisthis");
        }

        if (OVRInput.Get(OVRInput.Button.Any))
        {
            Debug.Log("YES");
        }
    }
}
