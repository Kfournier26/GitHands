using UnityEngine;

public class OculusHandInput : MonoBehaviour
{
    private void Update()
    {
        var leftHand = GenericHandInputManager.Instance.LeftHand;
        var rightHand = GenericHandInputManager.Instance.RightHand;

        rightHand.primary = OculusInputToFloat(OVRInput.Button.One);
        rightHand.secondary = OculusInputToFloat(OVRInput.Button.Two);
        rightHand.point = Input.GetAxis("Oculus_GearVR_RIndexTrigger");
        rightHand.grasp = Input.GetAxis("Oculus_GearVR_RHandTrigger");
        rightHand.thumb = Input.GetButton("Oculus_GearVR_RThumb") || Input.GetButton("Oculus_GearVR_Button1_Touch") || Input.GetButton("Oculus_GearVR_Button2_Touch") || Input.GetButton("Oculus_GearVR_RThumbrest");


        leftHand.primary = OculusInputToFloat(OVRInput.Button.Three);
        leftHand.secondary = OculusInputToFloat(OVRInput.Button.Four);
        leftHand.point = Input.GetAxis("Oculus_GearVR_LIndexTrigger");
        leftHand.grasp = Input.GetAxis("Oculus_GearVR_LHandTrigger");
        leftHand.thumb = Input.GetButton("Oculus_GearVR_LThumb") || Input.GetButton("Oculus_GearVR_Button3_Touch") || Input.GetButton("Oculus_GearVR_Button4_Touch") || Input.GetButton("Oculus_GearVR_LThumbrest");
    }

    float OculusInputToFloat(OVRInput.Button button)
    {
        return OVRInput.Get(button) ? 1f : 0;
    }
}
