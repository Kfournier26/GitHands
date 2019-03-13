using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMRcontrol : MonoBehaviour
{
    private Animator theAnimator;
    public string pointerAnimationName, pointerAnimationReverseName, thumbAnimationName, thumbAnimationReverseName, graspAnimationName, graspAnimationReverseName;
    public HandControllerType handType;
    //[SerializeField]
    //public GameObject HandLeft;
    //public GameObject HandRight;

    [SerializeField]
    public Vector3 PositionOffset;
    [SerializeField]
    public Vector3 RotationOffset;


    // Use this for initialization
    void Start()
    {

        theAnimator = GetComponent<Animator>();
        //transform.Translate(Vector3.forward * Time.deltaTime);
        //HandRight.transform.Translate(-.07f, .01f, -.05f);
        //HandRight.transform.Rotate(1, 0, 15);

        //HandLeft.transform.Translate(.07f, .01f, .05f);
        //HandLeft.transform.Rotate(-1, 0, -15);

        this.gameObject.transform.Translate(PositionOffset);
        this.gameObject.transform.Rotate(RotationOffset);
    }

    private HandControllerInput GetHand()
    {
        switch (handType)
        {
            case HandControllerType.LeftHand:
                return GenericHandInputManager.Instance.LeftHand;
            case HandControllerType.RightHand:
                return GenericHandInputManager.Instance.RightHand;
        }
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = OVRInput.GetLocalControllerPosition(Controller);
        //transform.localRotation = OVRInput.GetLocalControllerRotation(Controller);
        //transform.localPosition = InputTracking.GetLocalPosition(XRNode.LeftHand);
        // transform.localPosition = UnityEngine.Input.GetJoystickNames();


        UnityEngine.Input.GetJoystickNames();

        var hand = GetHand();

        if (hand != null)
        {

            theAnimator.Play(hand.point <= 0.5 ? pointerAnimationReverseName : pointerAnimationName);
            theAnimator.Play(hand.grasp <= 0.5 ? graspAnimationReverseName : graspAnimationName);
            theAnimator.Play(hand.thumb ? thumbAnimationName : thumbAnimationReverseName);
        }
    }
}
