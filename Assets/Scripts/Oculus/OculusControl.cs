using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OculusControl : MonoBehaviour
{
    public OVRInput.Controller Controller;
    private Animator theAnimator;
    public string pointerAnimationName, pointerAnimationReverseName, thumbAnimationName, thumbAnimationReverseName, graspAnimationName, graspAnimationReverseName;
    public HandControllerType handType;
    [SerializeField]
    
    void Start()
    {
        theAnimator = GetComponent<Animator>();
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
    void Update()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(Controller);
        transform.localRotation = OVRInput.GetLocalControllerRotation(Controller);

        var hand = GetHand();

        if (hand != null)
        {

            theAnimator.Play(hand.point <= 0.5 ? pointerAnimationReverseName : pointerAnimationName);
            theAnimator.Play(hand.grasp <= 0.5 ? graspAnimationReverseName : graspAnimationName);
            theAnimator.Play(hand.thumb ? thumbAnimationName : thumbAnimationReverseName);
        }
        
    }

}