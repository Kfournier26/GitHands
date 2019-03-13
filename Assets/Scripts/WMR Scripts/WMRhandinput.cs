using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMRhandinput : MonoBehaviour {

	
	// Update is called once per frame
	private void Update ()
    {
        var leftHand = GenericHandInputManager.Instance.LeftHand;
        var rightHand = GenericHandInputManager.Instance.RightHand;

        rightHand.point = Input.GetAxis("WMR_Trigger_Right");
        rightHand.grasp = Input.GetAxis("WMR_Grip_Right");
        rightHand.thumb = Input.GetButton("WMR_Thumbstick_Press_Right") || Input.GetButton("WMR_Thumbstick_Horizontal_Right") || Input.GetButton("WMR_Thumbstick_Vertical_Right");

        leftHand.point = Input.GetAxis("WMR_Trigger_Left");
        leftHand.grasp = Input.GetAxis("WMR_Grip_Left");
        leftHand.thumb = Input.GetButton("WMR_Thumbstick_Press_Left") || Input.GetButton("WMR_Thumbstick_Horizontal_Left") || Input.GetButton("WMR_Thumbstick_Vertical_Left");

    }
}
